using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Security.Policy;

namespace SunnyTest
{

    /// <summary>
    ///  Sunny HTTP 请求返回操作对象
    /// </summary>
    public class Request
    {

        public String 请求客户端IP = "";
        /// <summary>
        /// Sunny HTTP 请求操作对象
        /// </summary>
        public SunnyRequest request = null;
        /// <summary>
        /// Sunny HTTP 返回操作对象
        /// </summary>
        public SunnyResponse response = null;

        public Request(int MessageId)
        {
            request = new SunnyRequest(MessageId);
            response = new SunnyResponse(MessageId);
            IntPtr c = Sunny.GetRequestClientIp(MessageId);
            if (c.ToInt64() > 0)
            {
                请求客户端IP = Tool.PtrToString(c);
                Sunny.Free(c);//释放Sunny接收的指针
            }
        }
    }

    public class SunnyRequest
    {
        private int MessageId = 0;
        public SunnyRequest(int _MessageId)
        {
            MessageId = _MessageId;
        }
        /// <summary>
        /// 请求协议头中去除Gzip 若不删除压缩标记，返回数据可能是压缩后的
        /// </summary>
        public void 删除压缩标记()
        {
            IntPtr a = Tool.StringToIntptr("Accept-Encoding");
            Sunny.DelRequestHeader(MessageId, a);
            Tool.PtrFree(a);
        }

        /// <summary>
        /// 请求设置超时-毫秒
        /// </summary>
        /// <param name="超时时间">超时时间-毫秒</param>
        public void 置请求超时(int 超时时间)
        {
            Sunny.SetRequestOutTime(MessageId, 超时时间);
        }
        /// <summary>
        /// 终止请求 在发起请求时使用,使用本命令后,这个请求将不会被发送出去
        /// </summary>
        public void 终止请求()
        {
            string key = "Connection";
            string val = "Close";
            IntPtr i1 = Tool.StringToIntptr(key);
            IntPtr i2 = Tool.StringToIntptr(val);
            Sunny.SetResponseHeader(MessageId, i1, i2);
            Tool.PtrFree(i1);
            Tool.PtrFree(i2);
        }
        /// <summary>
        /// 置代理
        /// </summary>
        /// <param name="代理地址">仅支持Socket5和http 例如 socket5://admin:123456@127.0.0.1:8888 或 http://admin:123456@127.0.0.1:8888</param>
        public bool 置代理(string 代理)
        {
            IntPtr _代理 = Tool.StringToIntptr(代理);
            bool ret = Sunny.SetRequestProxy(MessageId, _代理);
            Tool.PtrFree(_代理);
            return ret;
        }

        public bool 修改Url(string 欲转向地址)
        {
            IntPtr A = Tool.StringToIntptr(欲转向地址);
            bool b = Sunny.SetRequestUrl(MessageId, A);
            Tool.PtrFree(A);
            return b;
        }
        public bool 修改Body_字节集(byte[] 欲修改为的Body)
        {
            IntPtr A = Tool.BytesToIntptr(欲修改为的Body);
            int o = Sunny.SetRequestData(MessageId, A, 欲修改为的Body.Length);
            Tool.PtrFree(A);
            return o == 1;
        }

        /// <summary>
        /// 传的什么编码就是什么编码
        /// </summary>
        /// <param name="欲修改为的Body"></param>
        /// <returns></returns>
        public bool 修改Body_字符串_GBK(string 欲修改为的Body)
        {
            byte[] bs = Tool.StrToBytes(欲修改为的Body);
            IntPtr A = Tool.BytesToIntptr(bs);
            int o = Sunny.SetRequestData(MessageId, A, bs.Length);
            Tool.PtrFree(A);
            return o == 1;
        }

        /// <summary>
        /// 传的什么编码就是什么编码
        /// </summary>
        /// <param name="欲修改为的Body"></param>
        /// <returns></returns>
        public bool 修改Body_字符串_UTF8(string 欲修改为的Body)
        {
            byte[] bs = Tool.StrToBytes(欲修改为的Body, "UTF-8");
            IntPtr A = Tool.BytesToIntptr(bs);
            int o = Sunny.SetRequestData(MessageId, A, bs.Length);
            Tool.PtrFree(A);
            return o == 1;
        }
        /// <summary>
        /// 若本身无指定的协议头，即为新增，若有则为修改
        /// </summary>
        /// <param name="Heads">【可多条 一行一个 例如 Accept: image/gif】  【\r\n 分割】</param>
        public void 修改或新增协议头(string Heads)
        {
            IntPtr a = (IntPtr)(0);
            IntPtr b = (IntPtr)(0);
            string[] arr = Regex.Split(Heads, "\r\n", RegexOptions.IgnoreCase);
            foreach (string s in arr)
            {
                string[] arr1 = Regex.Split(s, ": ", RegexOptions.IgnoreCase);
                if (arr1.Length == 2)
                {
                    string name = arr1[0];
                    string value = arr1[1].Replace(name + ": ", "");
                    a = Tool.StringToIntptr(name);
                    b = Tool.StringToIntptr(value);
                    Sunny.SetRequestHeader(MessageId, a, b);
                    Tool.PtrFree(a);
                    Tool.PtrFree(b);
                }
            }
        }
        /// <summary>
        /// 若本身无指定的协议头，即为新增，若有则为修改
        /// </summary>
        /// <param name="key">协议头名称</param>
        /// <param name="value">协议头值</param>
        public void 修改或新增协议头_单条(string key, string value)
        {
            IntPtr i1 = Tool.StringToIntptr(key);
            IntPtr i2 = Tool.StringToIntptr(value);
            Sunny.SetRequestHeader(MessageId, i1, i2);
            Tool.PtrFree(i1);
            Tool.PtrFree(i2);
        }

        public string 取全部协议头()
        {
            IntPtr i1 = Sunny.GetRequestAllHeader(MessageId);
            if (i1.ToInt64() < 1)
            {
                return "";
            }
            string sa = Tool.PtrToString(i1);
            Sunny.Free(i1);//释放Sunny接收的指针
            return sa;
        }
        public string 取协议头_单条(string key)
        {
            IntPtr a = Tool.StringToIntptr(key);
            IntPtr i1 = Sunny.GetRequestHeader(MessageId, a);
            Tool.PtrFree(a);
            if (i1.ToInt64() < 1)
            {
                return "";
            }
            string sa = Tool.PtrToString(i1);
            Sunny.Free(i1);//释放Sunny接收的指针
            return sa;
        }
        public void 删协议头_单条(string key)
        {
            IntPtr a = Tool.StringToIntptr(key);
            Sunny.DelRequestHeader(MessageId, a);
            Tool.PtrFree(a);
        }
        /// <summary>
        /// 删除全部协议头
        /// </summary>
        public void 删除全部协议头()
        {
            IntPtr a = (IntPtr)(0);
            string[] arr = Regex.Split(取全部协议头(), "\r\n", RegexOptions.IgnoreCase);
            foreach (string s in arr)
            {
                string[] arr1 = Regex.Split(s, ": ", RegexOptions.IgnoreCase);
                if (arr1.Length >= 1)
                {
                    a = Tool.StringToIntptr(arr1[0]);
                    Sunny.DelRequestHeader(MessageId, a);
                    Tool.PtrFree(a);
                }
            }
        }
        /// <summary>
        /// 修改全部Cookie 设置请求全部Cookies 例如 a=1;b=2;c=3
        /// </summary>
        /// <param name="cookie">例如:a=1;b=2;c=3   无需前缀（Cookie: ）</param>
        public void 修改全部Cookie(string cookie)
        {
            IntPtr a = Tool.StringToIntptr(cookie);
            Sunny.SetRequestAllCookie(MessageId, a);
            Tool.PtrFree(a);
        }

        /// <summary>
        /// 修改全部Cookie 设置请求全部Cookies 例如 a=1;b=2;c=3
        /// </summary>
        /// <param name="cookie">例如:a=1;b=2;c=3   无需前缀（Cookie: ）</param>
        public void 修改Cookie_单条(string key, string value)
        {
            IntPtr a = Tool.StringToIntptr(key);
            IntPtr b = Tool.StringToIntptr(value);
            Sunny.SetRequestCookie(MessageId, a, b);
            Tool.PtrFree(a);
            Tool.PtrFree(b);
        }

        public string 取全部cookie()
        {
            IntPtr i1 = Sunny.GetRequestALLCookie(MessageId);
            if (i1.ToInt64() < 1)
            {
                return "";
            }
            string sa = Tool.PtrToString(i1);
            Sunny.Free(i1);//释放Sunny接收的指针
            return sa;
        }

        public string 取cookie_单条(string key)
        {
            IntPtr a = Tool.StringToIntptr(key);
            IntPtr i1 = Sunny.GetRequestCookie(MessageId, a);
            Tool.PtrFree(a);
            if (i1.ToInt64() < 1)
            {
                return "";
            }
            string sa = Tool.PtrToString(i1);
            Sunny.Free(i1);//释放Sunny接收的指针
            return sa;

        }

        public string 取cookie_单条_不包含键(string key)
        {
            IntPtr a = Tool.StringToIntptr(key);
            IntPtr i1 = Sunny.GetRequestCookie(MessageId, a);
            Tool.PtrFree(a);
            if (i1.ToInt64() < 1)
            {
                return "";
            }
            string s = Tool.PtrToString(i1);
            string[] arr = Regex.Split(s, "=", RegexOptions.IgnoreCase);
            Sunny.Free(i1);//释放Sunny接收的指针
            if (arr.Length < 2)
            {
                return "";
            }
            string value = arr[1].Replace(arr[0] + "=", "");
            return value;
        }


        public int 取Body_长度()
        {
            return Sunny.GetRequestBodyLen(MessageId);
        }
        /// <summary>
        /// 获取GBK字符串
        /// </summary>
        /// <returns></returns>
        public string 取POST数据_字符串_GBK()
        {
            byte[] s = 取POST数据_字节集();
            return Tool.BytesToStr(s);
        }
        /// <summary>
        /// 将UTF8 转为GBK
        /// </summary>
        /// <returns></returns>
        public string 取POST数据_字符串_UTF8()
        {
            byte[] s = 取POST数据_字节集();
            return Tool.BytesToStr(s, "UTF-8");
        }
        public byte[] 取POST数据_字节集()
        {
            IntPtr p = Sunny.GetRequestBody(MessageId);
            Console.WriteLine(MessageId + "|取POST数据_字节集|" + p);
            if (p.ToInt64() < 1)
            {
                return new byte[0];
            }
            byte[] aa = Tool.PtrToBytes(p, 取Body_长度());
            Sunny.Free(p);//释放Sunny接收的指针
            return aa;
        }
    }


    public class SunnyResponse
    {
        private int MessageId = 0;
        public SunnyResponse(int _MessageId)
        {
            MessageId = _MessageId;
        }


        public int 取正文长度()
        {
            return Sunny.GetResponseBodyLen(MessageId);
        }

        public string 取响应内容_GBK()
        {
            byte[] s = 取响应内容_字节集();
            return Tool.BytesToStr(s);
        }
        public string 取响应内容_UTF8()
        {
            byte[] s = 取响应内容_字节集();
            return Tool.BytesToStr(s, "UTF-8");
        }
        public byte[] 取响应内容_字节集()
        {
            IntPtr p = Sunny.GetResponseBody(MessageId);
            if (p.ToInt64() < 1)
            {
                return new byte[0];
            }
            byte[] aa = Tool.PtrToBytes(p, 取正文长度());
            Sunny.Free(p);//释放Sunny接收的指针
            var contentEncoding = 取协议头("Content-Encoding");
            if (contentEncoding == "br") return SunnyPublic.Br解压缩(aa);
            if (contentEncoding == "gzip") return SunnyPublic.Gzip解压缩(aa);
            if (contentEncoding == "deflate") return SunnyPublic.Deflate解压缩(aa);
            return aa;
        }

        public string 取协议头(string key)
        {
            IntPtr a = Tool.StringToIntptr(key);
            IntPtr i1 = Sunny.GetResponseHeader(MessageId, a);
            Tool.PtrFree(a);
            if (i1.ToInt64() < 1)
            {
                return "";
            }
            return Tool.PtrToString(i1);
        }

        public string 取全部协议头()
        {
            IntPtr i1 = Sunny.GetResponseAllHeader(MessageId);
            if (i1.ToInt64() < 1)
            {
                return "";
            }
            return Tool.PtrToString(i1);
        }


        public int 取状态码()
        {
            return Sunny.GetResponseStatusCode(MessageId);
        }
        public string 取状态码对应状态文本()
        {
            IntPtr o = Sunny.GetResponseStatus(MessageId);
            if (o.ToInt64() < 1)
            {
                return "";
            }
            string[] res_list = Regex.Split(Tool.PtrToString(o), " ", RegexOptions.IgnoreCase);
            string res = "";
            if (res_list.Length >= 2)
            {
                foreach (string s in res_list)
                {
                    if (res == "")
                    {
                        res = s;
                    }
                    else
                    {
                        res = res + " " + s;
                    }

                }
            }
            return res;
        }


        public bool 修改响应内容_字节集(byte[] 预修改为的内容)
        {
            IntPtr A = Tool.BytesToIntptr(预修改为的内容);
            bool o = Sunny.SetResponseData(MessageId, A, 预修改为的内容.Length);
            Tool.PtrFree(A);
            return o;
        }


        /// <summary>
        /// 你传的是什么编码就是什么编码
        /// </summary>
        /// <param name="欲修改为的Body"></param>
        /// <returns></returns>
        public bool 修改响应内容_字符串(string 欲修改为的Body)
        {
            byte[] bs = Tool.StrToBytes(欲修改为的Body);
            IntPtr A = Tool.BytesToIntptr(bs);
            bool o = Sunny.SetResponseData(MessageId, A, bs.Length);
            Tool.PtrFree(A);
            return o;
        }
        /// <summary>
        /// 转为UTF8提交
        /// </summary>
        /// <param name="欲修改为的Body"></param>
        /// <returns></returns>
        public bool 修改响应内容_字符串_UTF8(string 欲修改为的Body)
        {
            byte[] bs = Tool.StrToBytes(欲修改为的Body, "UTF-8");
            bs = 压缩(bs);
            IntPtr A = Tool.BytesToIntptr(bs);
            bool o = Sunny.SetResponseData(MessageId, A, bs.Length);
            Tool.PtrFree(A);
            return o;
        }

        public byte[] 压缩(byte[] aa)
        {
            var contentEncoding = 取协议头("Content-Encoding");
            if (contentEncoding == "br") return SunnyPublic.Br压缩(aa);
            if (contentEncoding == "gzip") return SunnyPublic.Gzip压缩(aa);
            if (contentEncoding == "deflate") return SunnyPublic.Deflate压缩(aa);
            return aa;
        }

        public void 删除协议头_单条(string key)
        {
            IntPtr a = Tool.StringToIntptr(key);
            Sunny.DelResponseHeader(MessageId, a);
            Tool.PtrFree(a);
        }

        /// <summary>
        /// 删除全部协议头
        /// </summary>
        public void 删除全部协议头()
        {
            IntPtr a = (IntPtr)(0);
            string[] arr = Regex.Split(取全部协议头(), "\r\n", RegexOptions.IgnoreCase);
            foreach (string s in arr)
            {
                string[] arr1 = Regex.Split(s, ":", RegexOptions.IgnoreCase);
                if (arr1.Length >= 1)
                {
                    a = Tool.StringToIntptr(arr1[0]);
                    Sunny.DelResponseHeader(MessageId, a);
                    Tool.PtrFree(a);
                }
            }
        }


        public void 修改或新增协议头_单条(string key, string value)
        {
            IntPtr i1 = Tool.StringToIntptr(key);
            IntPtr i2 = Tool.StringToIntptr(value);
            Sunny.SetResponseHeader(MessageId, i1, i2);
            Tool.PtrFree(i1);
            Tool.PtrFree(i2);
        }

        /// <summary>
        /// 此命令会先将返回的协议头全部删除，再添加
        /// </summary>
        /// <param name="Heads"></param>
        public void 修改或新增协议头(string Heads)
        {
            IntPtr a = Tool.StringToIntptr(Heads);
            Sunny.SetResponseAllHeader(MessageId, a);
            Tool.PtrFree(a);
        }

        /// <summary>
        /// 修改状态码 
        /// </summary>
        /// <param name="状态码">默认200</param>
        public void 修改状态码(int 状态码 = 200)
        {
            Sunny.SetResponseStatus(MessageId, 状态码);
        }


    }


}
