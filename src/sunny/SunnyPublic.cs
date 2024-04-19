using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunnyTest
{
    /// <summary>
    /// 本类为Sunny 所有的公开函数
    /// </summary>
    class SunnyPublic
    {
        /// <summary>
        /// 获取SunnyNet版本
        /// </summary>
        public static string GetSunnyVersion()
        {
            IntPtr p = Sunny.GetSunnyVersion(); 
            string  s = Tool.PtrToString(p);
            Sunny.Free(p);//释放Sunny接收的指针
            return  s;
        }

        /// <summary>
        /// 取UDP 接收/发送 的数据
        /// </summary>
        public static byte[] UDP_取Body(System.Int32 MessageId)
        {
            IntPtr p = Sunny.GetUdpData(MessageId);
            byte[] bs = Tool.PtrAutoToBytes(p);
            Sunny.Free(p);//释放Sunny接收的指针
            return bs;
        }
        /// <summary>
        /// 修改  UDP 接收/发送 的数据
        /// </summary>
        public static bool UDP_修改Body(System.Int32 MessageId, byte[] 欲修改的Body)
        {
            IntPtr _欲修改的Body = Tool.BytesToIntptr(欲修改的Body);
            bool ret = Sunny.SetUdpData(MessageId, _欲修改的Body, 欲修改的Body.Length);
            Tool.PtrFree(_欲修改的Body);
            return ret;
        }
        /// <summary>
        /// 指定的UDP连接 模拟客户端向服务器端主动发送数据
        /// </summary>
        public static bool UDP_向服务器发送消息(System.Int32 唯一id, byte[] 欲修改的Body)
        {
            IntPtr _欲修改的Body = Tool.BytesToIntptr(欲修改的Body);
            bool ret = Sunny.UdpSendToServer(唯一id, _欲修改的Body, 欲修改的Body.Length);
            Tool.PtrFree(_欲修改的Body);
            return ret;
        }
        /// <summary>
        /// 指定的UDP连接 模拟服务器端向客户端主动发送数据
        /// </summary>
        public static bool UDP_向客户端发送消息(System.Int32 唯一id, byte[] 欲修改的Body)
        {
            IntPtr _欲修改的Body = Tool.BytesToIntptr(欲修改的Body);
            bool ret = Sunny.UdpSendToClient(唯一id, _欲修改的Body, 欲修改的Body.Length);
            Tool.PtrFree(_欲修改的Body);
            return ret;
        }
        /// <summary>
        /// ws、wss 取 接收/发送 的消息长度
        /// </summary>
        public static System.Int32 ws_取Body长度(System.Int32 MessageId)
        {
            System.Int32 ret = Sunny.GetWebsocketBodyLen(MessageId);
            return ret;
        }


        /// <summary>
        /// ws、wss 取 接收/发送 的消息
        /// </summary>
        public static byte[] ws_取Body(System.Int32 MessageId)
        {
            IntPtr p = Sunny.GetWebsocketBody(MessageId);
            byte[] bs = Tool.PtrToBytes(p, ws_取Body长度(MessageId));
            Sunny.Free(p);//释放Sunny接收的指针
            return bs;
        }

        /// <summary>
        /// ws、wss 修改 接收/发送 的消息
        /// </summary>
        public static bool ws_修改Body(System.Int32 MessageId, byte[] 欲修改的Body)
        {
            IntPtr _欲修改的Body = Tool.BytesToIntptr(欲修改的Body);
            bool ret = Sunny.SetWebsocketBody(MessageId, _欲修改的Body, 欲修改的Body.Length);
            Tool.PtrFree(_欲修改的Body);
            return ret;
        }  
        /// <summary>
        /// ws、wss自动发送消息
        /// </summary>
        /// <param name="SendType">发送方向 向服务端发送=0 向客户端发送=1</param>
        /// <param name="唯一ID"></param>
        /// <param name="消息类型">ws/wss 发送或接收的消息类型 请使用[ Const.WSClient_ 下常量 ]</param>
        /// <param name="欲发送的Body"></param>
        /// <returns></returns>
        public static bool ws_发送数据(int SendType, System.Int32 唯一ID, System.Int32 消息类型, byte[] 欲发送的Body)
        {
            IntPtr _欲发送的Body = Tool.BytesToIntptr(欲发送的Body);
            bool ret;
            if (SendType == 0)
            {  
                ret = Sunny.SendWebsocketBody(唯一ID, 消息类型, _欲发送的Body, 欲发送的Body.Length); 
            }
            else
            { 
                ret = Sunny.SendWebsocketClientBody(唯一ID, 消息类型, _欲发送的Body, 欲发送的Body.Length); 
            }
            Tool.PtrFree(_欲发送的Body);
            return ret; 
        }
        /// <summary>
        /// 断开指定连接
        /// </summary>
        public static bool ws_断开指定连接(System.Int32 唯一ID)
        {
            bool ret = Sunny.CloseWebsocket(唯一ID);
            return ret;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MessageId"></param>
        /// <param name="消息类型"> 1=发送  2=接受 </param>
        /// <param name="欲修改的Body"></param>
        public static void Tcp_修改消息(System.Int32 MessageId, System.Int32 消息类型, byte[] 欲修改的Body)
        {
            IntPtr _欲修改的Body = Tool.BytesToIntptr(欲修改的Body);
            Sunny.SetTcpBody(MessageId, 消息类型, _欲修改的Body, 欲修改的Body.Length);
            Tool.PtrFree(_欲修改的Body);
        }

        /// <summary>
        /// 给TCP请求设置S5代理。仅在TCP 即将连接时有效
        /// </summary>
        /// <param name="MessageId"></param>
        /// <param name="代理">仅支持S5代理 例如 socket5://admin:123456@127.0.0.1:8888</param>
        /// <returns></returns>
        public static bool Tcp_设置代理(System.Int32 MessageId, string 代理)
        {
            IntPtr _代理 = Tool.StringToIntptr(代理);
            bool ret = Sunny.SetTcpAgent(MessageId, _代理);
            Tool.PtrFree(_代理);
            return ret;
        }


        /// <summary>
        /// 断开指定连接
        /// </summary>
        public static bool Tcp_断开指定连接(System.Int32 唯一ID)
        {
            bool ret = Sunny.TcpCloseClient(唯一ID);
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public static byte[] Tcp_取数据(System.Int32 数据指针, System.Int32 数据长度)
        {
            IntPtr a = (IntPtr)数据指针; 
            return Tool.PtrToBytes(a, 数据长度);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MessageId">回调中的 参数</param>
        /// <param name="新IP">例如“127.0.0.1:80”带上端口号</param>
        /// <returns></returns>
        public static bool Tcp_连接重定向(System.Int32 MessageId, string 新IP)
        {
            IntPtr _新IP = Tool.StringToIntptr(新IP);
            bool ret = Sunny.SetTcpConnectionIP(MessageId, _新IP);
            Tool.PtrFree(_新IP);
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public static System.Int32 Tcp_向服务器发送消息(System.Int32 唯一id, byte[] msg)
        {
            IntPtr _msg = Tool.BytesToIntptr(msg);
            System.Int32 ret = Sunny.TcpSendMsg(唯一id, _msg, msg.Length);
            Tool.PtrFree(_msg);
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public static System.Int32 Tcp_向客户端发送消息(System.Int32 唯一id, byte[] msg)
        {
            IntPtr _msg = Tool.BytesToIntptr(msg);
            System.Int32 ret = Sunny.TcpSendMsgClient(唯一id, _msg, msg.Length );
            Tool.PtrFree(_msg);
            return ret;
        }

        /// <summary>
        /// 自定义JS脚本
        /// </summary>
        public static string 执行脚本方法(int 类型, string 参数)
        {
            IntPtr _参数 = Tool.StringToIntptr(参数);
            IntPtr p = Sunny.ScriptCall(类型, _参数);
            string ret = Tool.PtrToString(p);
            Tool.PtrFree(_参数);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// 成功返回空文本 失败返回错误信息
        /// </summary>
        public static string 设置脚本代码(string 代码)
        {
            IntPtr _代码 = Tool.StringToIntptr(代码);
            IntPtr p = Sunny.SetScript(_代码);
            string ret = Tool.PtrToString(p);
            Tool.PtrFree(_代码); 
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void 设置自定义JS脚本日志回调函数(IntPtr address)
        {
            Sunny.SetScriptLogCallAddress(address);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool 添加证书使用规则(string Host, CertificateManager 证书, System.Int32 使用规则)
        { 
            IntPtr _Host = Tool.StringToIntptr(Host);
            bool ret = Sunny.AddHttpCertificate(_Host, 证书.获取证书Context(), 使用规则);
            Tool.PtrFree(_Host);
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void 删除证书使用规则(string Host)
        {
            IntPtr _Host = Tool.StringToIntptr(Host);
            Sunny.DelHttpCertificate(_Host);
            Tool.PtrFree(_Host);
        }

        /// <summary>
        /// Webp转Png
        /// </summary>
        /// <param name="webp文件路径">例如：c:\123.webp</param>
        /// <param name="保存png文件路径">例如：c:\123.png</param>
        /// <returns></returns>
        public static bool Webp转Png(string webp文件路径, string 保存png文件路径)
        {
            byte[] a = Tool.ANSI2utf8(webp文件路径);
            byte[] B = Tool.ANSI2utf8(保存png文件路径);
            IntPtr _webp文件路径 = Tool.BytesToIntptr(a);
            IntPtr _保存png文件路径 = Tool.BytesToIntptr(B);
            bool ret = Sunny.WebpToPng(_webp文件路径, _保存png文件路径);
            Tool.PtrFree(_webp文件路径);
            Tool.PtrFree(_保存png文件路径);
            return ret;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="webp文件路径">例如：c:\123.webp</param>
        /// <param name="保存Jpg文件路径">例如：c:\123.jpg</param>
        /// <param name="质量">1-100 默认75</param> 
        /// <returns></returns>
        public static bool Webp转Jpg(string webp文件路径, string 保存Jpg文件路径, System.Int32 质量)
        {
            byte[] a = Tool.ANSI2utf8(webp文件路径);
            byte[] B = Tool.ANSI2utf8(保存Jpg文件路径);
            IntPtr _webp文件路径 = Tool.BytesToIntptr(a);
            IntPtr _保存Jpg文件路径 = Tool.BytesToIntptr(B);
            bool ret = Sunny.WebpToJpeg(_webp文件路径, _保存Jpg文件路径, 质量);
            Tool.PtrFree(_webp文件路径);
            Tool.PtrFree(_保存Jpg文件路径);
            return ret;
        }

        /// <summary>
        /// 失败返回空byte[]
        /// </summary>
        public static byte[] Webp转Jpg_2(byte[] webp图片, System.Int32 质量)
        {
            IntPtr _webp图片 = Tool.BytesToIntptr(webp图片);
            IntPtr p = Sunny.WebpToJpegBytes(_webp图片, webp图片.Length, 质量);
            byte[] ret =Tool.PtrAutoToBytes(p);
            Tool.PtrFree(_webp图片);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// 失败返回空byte[]
        /// </summary>
        public static byte[] Webp转Png_2(byte[] webp图片)
        {
            IntPtr _webp图片 = Tool.BytesToIntptr(webp图片);
            IntPtr p = Sunny.WebpToPngBytes(_webp图片, webp图片.Length);
            byte[] ret = Tool.PtrAutoToBytes(p);
            Tool.PtrFree(_webp图片);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public static string PB转PbJSON(byte[] PB数据)
        {
            IntPtr _PB数据 = Tool.BytesToIntptr(PB数据);
            IntPtr p = Sunny.PbToJson(_PB数据, PB数据.Length);
            string ret = Tool.PtrToString(p);
            Tool.PtrFree(_PB数据);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public static byte[] PbJson转Pb(string pbjson)
        {
            byte[] V = Tool.StrToBytes(pbjson);
            IntPtr _pbjson =Tool.BytesToIntptr(V);
            IntPtr p = Sunny.JsonToPB(_pbjson, V.Length);
            byte[] ret =Tool.PtrAutoToBytes(p);
            Tool.PtrFree(_pbjson);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// Gzip解压缩
        /// </summary>
        public static byte[] Gzip解压缩(byte[] bin)
        {
            IntPtr _bin = Tool.BytesToIntptr(bin);
            IntPtr p = Sunny.GzipUnCompress(_bin, bin.Length);
            byte[] ret = Tool.PtrAutoToBytes(p);
            Tool.PtrFree(_bin);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// Gzip压缩
        /// </summary>
        public static byte[] Gzip压缩(byte[] bin)
        {
            IntPtr _bin = Tool.BytesToIntptr(bin);
            IntPtr p = Sunny.GzipCompress(_bin, bin.Length);
            byte[] ret = Tool.PtrAutoToBytes(p);
            Tool.PtrFree(_bin);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// (可能等同于zlib解压缩)
        /// </summary>
        public static byte[] Deflate解压缩(byte[] bin)
        {
            IntPtr _bin = Tool.BytesToIntptr(bin);
            IntPtr p = Sunny.DeflateUnCompress(_bin, bin.Length);
            byte[] ret = Tool.PtrAutoToBytes(p);
            Tool.PtrFree(_bin);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// (可能等同于zlib压缩)
        /// </summary>
        public static byte[] Deflate压缩(byte[] bin)
        {
            IntPtr _bin = Tool.BytesToIntptr(bin);
            IntPtr p = Sunny.DeflateCompress(_bin, bin.Length);
            byte[] ret = Tool.PtrAutoToBytes(p);
            Tool.PtrFree(_bin);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// brotli 压缩
        /// </summary>
        public static byte[] Br压缩(byte[] bin)
        {
            IntPtr _bin = Tool.BytesToIntptr(bin);
            IntPtr p = Sunny.BrCompress(_bin, bin.Length);
            byte[] ret = Tool.PtrAutoToBytes(p);
            Tool.PtrFree(_bin);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// brotli 解压缩
        /// </summary>
        public static byte[] Br解压缩(byte[] bin)
        {
            IntPtr _bin = Tool.BytesToIntptr(bin);
            IntPtr p = Sunny.BrUnCompress(_bin, bin.Length);
            byte[] ret = Tool.PtrAutoToBytes(p);
            Tool.PtrFree(_bin);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// Zlib压缩
        /// </summary>
        public static byte[] Zlib压缩(byte[] bin)
        {
            IntPtr _bin = Tool.BytesToIntptr(bin);
            IntPtr p = Sunny.ZlibCompress(_bin, bin.Length);
            byte[] ret = Tool.PtrAutoToBytes(p);
            Tool.PtrFree(_bin);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

        /// <summary>
        /// Zlib解压缩
        /// </summary>
        public static byte[] Zlib解压缩(byte[] bin)
        {
            IntPtr _bin = Tool.BytesToIntptr(bin);
            IntPtr p = Sunny.ZlibUnCompress(_bin, bin.Length);
            byte[] ret = Tool.PtrAutoToBytes(p);
            Tool.PtrFree(_bin);
            Sunny.Free(p);//释放Sunny接收的指针
            return ret;
        }

    }
}
