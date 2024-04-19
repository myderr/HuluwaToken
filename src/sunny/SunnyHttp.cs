using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunnyTest
{
    /// <summary>
    /// SunnyHTTP 功能不强，但是不会处理协议头大小写 我用过很多模块 总会自动的去处理协议头大小写
    /// </summary>
    class SunnyHttp
    {

        private int Context = 0;
        public SunnyHttp()
        {
            Context = Sunny.CreateHTTPClient();
            if (Context > 0)
            {
                是否禁止重定向(false);
            }
        }
        ~SunnyHttp()
        {
            //自动销毁
            Sunny.RemoveHTTPClient(Context);
            Context = 0;
        }

        public void 重新创建()
        {
            Sunny.RemoveHTTPClient(Context);
            Context = Sunny.CreateHTTPClient();
            if (Context > 0)
            {
                是否禁止重定向(false);
            }
        }
        public string 取错误信息()
        {
            IntPtr p = Sunny.HTTPClientGetErr(Context);
            if (p.ToInt64() < 1)
            {
                return "";
            }
            string a = Tool.PtrToString(p);
            Sunny.Free(p);//释放Sunny接收的指针
            return a;
        }
        /// <summary>
        /// 打开(Open)
        /// </summary>
        /// <param name="Method">POST/GET/...</param>
        /// <param name="url">https://baidu.com/............ </param>
        /// <returns></returns>
        public void 打开(string Method, string url)
        {
            IntPtr A = Tool.StringToIntptr(Method.ToUpper());
            IntPtr B = Tool.StringToIntptr(url);
            Sunny.HTTPOpen(Context, A, B);
            Tool.PtrFree(A);
            Tool.PtrFree(B);
        }
        /// <summary>
        /// 设置重定向 是否禁止重定向 true=禁止重定向
        /// </summary>
        /// <param name="Redirect">是否禁止重定向 true=禁止重定向 </param>
        /// <returns></returns>
        public bool 是否禁止重定向(bool Redirect)
        {
            return Sunny.HTTPSetRedirect(Context, Redirect);
        }
        /// <summary>
        /// 置协议头
        /// </summary>
        /// <param name="协议头名称"></param>
        /// <param name="协议头值"></param>
        public void 置协议头(string 协议头名称, string 协议头值)
        {
            IntPtr A1 = Tool.StringToIntptr(协议头名称);
            IntPtr B1 = Tool.StringToIntptr(协议头值);
            Sunny.HTTPSetHeader(Context, A1, B1);
            Tool.PtrFree(A1);
            Tool.PtrFree(B1);
        }
        /// <summary>
        /// 设置证书
        /// </summary>
        /// <param name="证书">证书管理器</param>
        public bool 设置证书(CertificateManager 证书)
        {
            return Sunny.HTTPSetCertManager(Context, 证书.获取证书Context()); 
        }

        /// <summary>
        /// 设置代理IP  
        /// </summary>
        /// <param name="ProxyURL">仅支持Socket5和http 例如 socket5://admin:123456@127.0.0.1:8888 或 http://admin:123456@127.0.0.1:8888 </param> 
        public void 设置代理IP(string ProxyURL)
        {
            IntPtr A = Tool.StringToIntptr(ProxyURL);
            Sunny.HTTPSetProxyIP(Context, A);
            Tool.PtrFree(A); 
        }

        /// <summary>
        /// 设置超时
        /// </summary>
        /// <param name="连接超时">单位毫秒 默认 30000 / 30秒</param>
        /// <param name="发送超时">单位毫秒 默认 30000 / 30秒</param>
        /// <param name="接收超时">单位毫秒 默认 30000 / 30秒</param>
        public void 设置超时(int 连接超时 = 30000, int 发送超时 = 30000, int 接收超时 = 30000)
        {
            Sunny.HTTPSetTimeouts(Context, 连接超时, 发送超时, 接收超时);
        }
        /// <summary>
        ///  发送字节集
        /// </summary>
        /// <param name="data">要发送的数据</param>
        /// <returns></returns>
        public void 发送字节集(byte[] data)
        {
            IntPtr i1 = Tool.BytesToIntptr(data);
            Sunny.HTTPSendBin(Context, i1, data.Length);
            Tool.PtrFree(i1);
        }
        /// <summary>
        ///  发送
        /// </summary>
        /// <param name="data">要发送的文本数据</param>
        /// <returns></returns>
        public void 发送(string data)
        {
            Byte[] btData = System.Text.Encoding.Default.GetBytes(data);
            发送字节集(btData);
        }
        /// <summary>
        ///  取响应长度 发送数据之后有效
        /// </summary>
        /// <returns></returns>
        public int 取响应长度()
        {
            return Sunny.HTTPGetBodyLen(Context);
        }
        /// <summary>
        ///  取响应状态码 发送数据之后有效
        /// </summary>
        /// <returns></returns>
        public int 取响应状态码()
        {
            return Sunny.HTTPGetCode(Context);
        }
        /// <summary>
        ///  取响应全部Heads 发送数据之后有效
        /// </summary>
        /// <returns></returns>
        public string 取响应全部Heads()
        {
            IntPtr P = Sunny.HTTPGetHeads(Context);
            if (P.ToInt64() < 1)
            {
                return "";
            }
            string a = Tool.PtrToString(P);
            Sunny.Free(P);//释放Sunny接收的指针
            return a;
        }

        /// <summary>
        ///  取响应内容 发送数据之后有效
        /// </summary>
        /// <returns></returns>
        public byte[] 取响应内容()
        {
            int l = 取响应长度();
            IntPtr P = Sunny.HTTPGetBody(Context);
            if (P.ToInt64() < 1)
            {
                return new byte[0];
            }
            byte[] a = Tool.PtrToBytes(P, l);
            Sunny.Free(P);//释放Sunny接收的指针
            return a;
        }
    }
}
