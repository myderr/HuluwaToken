using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace SunnyTest
{
    /// <summary>
    /// WS客户端，请参考易语言用法
    /// </summary>
    public class WSClient
    {
        private int Context = 0;
        private Func<int, int, IntPtr, int, int, bool> wsBack = null;
        private WsDefaultCallback FuncCall;
        public WSClient()
        {
            Context = Sunny.CreateWebsocket();
        }

        ~WSClient()
        {
            //自动销毁
            Sunny.RemoveWebsocket(Context);
        }

        public void 重新创建()
        {
            Sunny.WebsocketClose(Context);
            Context = Sunny.CreateWebsocket();
        }

        public int 取客户端标识()
        {
            return Context;
        }
        /// <summary>
        /// 连接 WebSocket客户端连接
        /// </summary>
        /// <param name="url">  </param>
        /// <param name="Headers"></param>
        /// <param name="回调地址">回调函数 请传递符合参数类型的 方法函数</param>
        /// <param name="同步模式">如果为真 回调地址 将无效</param>
        /// <param name="代理地址">仅支持Socket5和http 例如 socket5://admin:123456@127.0.0.1:8888 或 http://admin:123456@127.0.0.1:8888</param> 
        /// <param name="cer"></param>
        /// <returns></returns>
        public bool 连接(string url, Func<int, int, IntPtr, int, int, bool> 回调地址, string Headers = "", bool 同步模式 = false, int 连接超时=30000, string 代理地址 = "" , CertificateManager cer = null)
        {
            wsBack = 回调地址;
            IntPtr A = Tool.StringToIntptr(url);
            IntPtr B = Tool.StringToIntptr(Headers);
            IntPtr D = Tool.StringToIntptr(代理地址);
            int c = 0;
            if (cer != null)
            {
                c = cer.获取证书Context();
            }
            FuncCall = new WsDefaultCallback(DefaultWsCallback);
            bool b = Sunny.WebsocketDial(Context, A, B, Marshal.GetFunctionPointerForDelegate(FuncCall), 同步模式,  D, c, 连接超时);
            Tool.PtrFree(A);
            Tool.PtrFree(B);
            Tool.PtrFree(D); 
            return b;
        }
        public void 断开()
        {
            Sunny.WebsocketClose(Context);
        }
        public string 取错误信息()
        {
            IntPtr p = Sunny.WebsocketGetErr(Context);
            if (p.ToInt64() < 1)
            {
                return "";
            }
            Sunny.Free(p);//释放Sunny接收的指针
            return Tool.PtrToString(p);
        }
        /// <summary>
        ///  webSocket客户端 发送数据，发送成功返回 真 如果发送后被断开连接，请检查编码，和第二个参数
        /// </summary>
        /// <param name="bin"></param>
        /// <param name="t">请使用 Const.WSClient_ [ 默认 Const.WSClient_BinaryMessage ]</param>
        /// <returns></returns>
        public bool 发送数据(byte[] bin, int t = 2)
        {
            IntPtr a = Tool.BytesToIntptr(bin);
            bool p = Sunny.WebsocketReadWrite(Context, a, bin.Length, t);
            Tool.PtrFree(a);
            return p;
        }
        /// <summary>
        ///  webSocket客户端 同步模式下取回数据，异步模式下无效 如果返回空字节数组 请取错误信息
        /// </summary>
        /// <param name="数据类型">请传递int地址 如：&i </param>
        /// <param name="超时时间">单位，毫秒 默认3000</param>
        /// <returns></returns>
        public  byte[] 接收数据(out int  数据类型, int 超时时间 = 3000)
        {
            数据类型 = Const.WSClient_invalid; 
            IntPtr p = Sunny.WebsocketClientReceive(Context, 超时时间 );
            if (p.ToInt64() < 1)
            {
                return new byte[0];
            } 
            long plen = Sunny.BytesToInt(p, 8); 
            byte[] mbin=Tool.PtrToBytes(p, 8, 8);  
            IntPtr p1 = Tool.BytesToIntptr(mbin);
            int msgtype = Sunny.BytesToInt(p1, 8);
            Tool.PtrFree(p1);
            数据类型 = msgtype;
            mbin = Tool.PtrToBytes(p, (int)plen, 16);
            Sunny.Free(p);//释放Sunny接收的指针
            return mbin;
        }

        public delegate void WsDefaultCallback(int Context, int 消息类型, IntPtr 数据指针, int 指针长度, int 数据类型);

        /// <summary>
        /// Ws客户端回调委托
        /// </summary>
        /// <param name="Context"></param>
        /// <param name="消息类型">1=接收消息 2=接收时连接被断开 3=发送时连接被断开</param>
        /// <param name="数据指针">消息类型=2、3时 这里是错误信息</param>
        /// <param name="指针长度"></param>
        /// <param name="数据类型">Const.WSClient_ (当消息类型=1时有效)</param>
        private void DefaultWsCallback(int Context, int 消息类型, IntPtr 数据指针, int 指针长度, int 数据类型)
        {
            if (wsBack != null)
            {
                wsBack(Context, 消息类型, 数据指针, 指针长度, 数据类型);
            }
        }

    }
}
