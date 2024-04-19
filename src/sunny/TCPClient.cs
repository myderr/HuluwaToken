using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace SunnyTest
{
    /// <summary>
    /// TCP客户端，请参考易语言用法
    /// </summary>
    public class TCPClient
    {
        private int Context = 0;
        private Func<int, int, IntPtr, int, bool> TcpBack = null;
        private TcpClientDefaultCallback FuncCall;

        public TCPClient()
        {
            Context = Sunny.CreateSocketClient();
        }
       
        ~TCPClient()
        {
            //自动销毁
            Sunny.RemoveSocketClient(Context);
        }
        
        public void 重新创建()
        {
            Sunny.RemoveSocketClient(Context);
            Context = Sunny.CreateSocketClient();
        }
        public int 取客户端标识()
        {
            return Context;
        }
        /// <summary>
        /// TCP客户端连接
        /// </summary>
        /// <param name="ip">要连接的IP地址</param>
        /// <param name="cer">证书管理器 不用的话New 一个传进来就行</param>
        /// <param name="回调地址">回调函数 请传递符合参数类型的 方法函数 </param>
        /// <param name="是否为TLS客户端">默认 假 </param>
        /// <param name="同步模式">默认假</param>
        /// <param name="代理地址">S5代理 格式socket5://127.0.0.1:8888 或 socket5://adminL123456@127.0.0.1:8888</param>
        /// <returns></returns>
        public bool 连接(string ip, Func<int, int, IntPtr, int, bool> 回调地址, CertificateManager cer = null, bool 是否为TLS客户端 = false, bool 同步模式 = false, string 代理地址 = "")
        {
            IntPtr A = Tool.StringToIntptr(ip);
            IntPtr B = Tool.StringToIntptr(代理地址);
            int c = 0;
            if (cer != null)
            {
                c = cer.获取证书Context();
            }
            TcpBack = 回调地址;
            FuncCall = new TcpClientDefaultCallback(DefaultTcpClientCallback);
            bool b = Sunny.SocketClientDial(Context, A, Marshal.GetFunctionPointerForDelegate(FuncCall), 是否为TLS客户端, 同步模式, B, c);
            Tool.PtrFree(A);
            Tool.PtrFree(B); 
            return b;
        }
        /// <summary>
        /// TCP客户端 断开连接
        /// </summary>
        public void 断开()
        {
            Sunny.SocketClientClose(Context);
        }
        public string 取错误信息()
        {
            IntPtr p = Sunny.SocketClientGetErr(Context);
            if (p.ToInt64() < 1)
            {
                return "";
            }
            Sunny.Free(p);//释放Sunny接收的指针
            return Tool.PtrToString(p);
        }
        /// <summary>
        ///  webSocket TCP客户端 发送数据，返回发送成功的字节数
        /// </summary>
        /// <param name="bin">要发送的数据</param>
        /// <param name="t">写入超时时间,单位，毫秒 默认30000 /30秒</param>
        /// <returns></returns>
        public int 发送数据(byte[] bin, int t = 30000)
        {
            IntPtr a = Tool.BytesToIntptr(bin);
            int p = Sunny.SocketClientWrite(Context, t, a, bin.Length);
            Tool.PtrFree(a);
            return p;
        }

        /// <summary>
        /// TCP客户端取回数据 同步模式下取回数据，异步模式下无效 如果返回空字节数组 请取错误信息
        /// </summary>
        /// <param name="超时时间">单位、毫秒，默认100毫秒</param>
        /// <returns></returns>
        public byte[] 取回数据(int 超时时间 = 100)
        {
            
            IntPtr p = Sunny.SocketClientReceive(Context, 超时时间);
            if (p.ToInt64() < 1)
            {
                return new byte[0];
            }
            Sunny.Free(p);//释放Sunny接收的指针
            return Tool.PtrAutoToBytes(p);
        }
        /// <summary>
        /// 置缓冲区大小 请在连接之前调用
        /// </summary>
        /// <param name="缓冲区大小"></param>
        /// <returns></returns>
        public bool 置缓冲区大小(int 缓冲区大小 = 4096)
        {
            bool b = Sunny.SocketClientSetBufferSize(Context, 缓冲区大小);
            return b;
        }

        public delegate void TcpClientDefaultCallback(int Context, int 消息类型, IntPtr 数据指针, int 指针长度);

        /// <summary>
        /// TCP客户端回调委托
        /// </summary>
        /// <param name="Context"></param>
        /// <param name="消息类型">1=接收消息 2=接收时连接被断开 3=发送时连接被断开 4=即将连接</param>
        /// <param name="数据指针">消息类型=2、3时 这里是错误信息</param>
        /// <param name="指针长度"></param>
        private void DefaultTcpClientCallback(int Context, int 消息类型, IntPtr 数据指针, int 指针长度)
        {
            if (TcpBack != null)
            {
                TcpBack(Context, 消息类型, 数据指针, 指针长度);
            }
        }
    }
}
