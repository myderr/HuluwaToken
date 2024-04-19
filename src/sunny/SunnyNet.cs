using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SunnyTest
{
    /// <summary>
    /// Sunny公共方法
    /// </summary>
    public class SunnyNet
    {
        static System.Func<int, int, int, int, string, string, string, int, bool> httpFunc = null;
        static System.Func<int, int, int, int, string, string, int, int, bool> wsFunc = null;
        static System.Func<int, string, string, int, int, IntPtr, int, int, int, bool> tcpFunc = null;
        static System.Func<int, string, string, int, int, int, int, bool> udpFunc = null;

        static NetHttpCallback HttpCALL;
        static NetTcpCallback TcpCALL;
        static NetUDPCallback UdpCALL;
        static NetWebsockCallback WebsocketCALL;


        private delegate void NetHttpCallback(int SunnyContext, int 唯一ID, int MessageId, int Type, IntPtr Method, IntPtr Url, IntPtr err, int pid);
        private delegate void NetTcpCallback(int SunnyContext, IntPtr 来源地址, IntPtr 远程地址, int 消息类型, int MessageId, IntPtr 数据指针, int 数据长度, int 唯一ID, int pid);
        private delegate void NetUDPCallback(int SunnyContext, IntPtr 来源地址, IntPtr 远程地址, int 事件类型, int MessageId, int 唯一ID, int pid);
        private delegate void NetWebsockCallback(int SunnyContext, int 唯一ID, int MessageId, int 消息类型, IntPtr Method, IntPtr Url, int pid, int WsMsgType);
        private static void DefaultNetTcpCallback(int SunnyContext, IntPtr _来源地址, IntPtr _远程地址, int _消息类型, int _MessageId, IntPtr _数据指针, int _数据长度, int _唯一ID, int pid)
        {
            if (tcpFunc != null)
            {
                tcpFunc(SunnyContext, Tool.PtrToString(_来源地址), Tool.PtrToString(_远程地址), _消息类型, _MessageId, _数据指针, _数据长度, _唯一ID, pid);
            }
        }
        private static void DefaultNetUDPCallback(int SunnyContext, IntPtr _来源地址, IntPtr _远程地址, int _事件类型, int _MessageId, int _唯一ID, int pid)
        {
            if (udpFunc != null)
            {
                udpFunc(SunnyContext, Tool.PtrToString(_来源地址), Tool.PtrToString(_远程地址), _事件类型, _MessageId, _唯一ID, pid);
            }
        }
        private static void DefaultNetWebsocketCallback(int SunnyContext, int 唯一ID, int MessageId, int 消息类型, IntPtr Method, IntPtr Url, int pid, int WsMsgType)
        {
            if (tcpFunc != null)
            {
                wsFunc(SunnyContext, 唯一ID, MessageId, 消息类型, Tool.PtrToString(Method), Tool.PtrToString(Url), pid, WsMsgType);
            }

        }
        private static void DefaultNetHttpCallback(int SunnyContext, int 唯一ID, int MessageId, int Type, IntPtr Method, IntPtr Url, IntPtr err, int pid)
        {
            if (httpFunc != null)
            {
                httpFunc(SunnyContext, 唯一ID, MessageId, Type, Tool.PtrToString(Method), Tool.PtrToString(Url), Tool.PtrToString(err), pid);
            }
        }

        private int SunnyNetContext = 0;
        public SunnyNet()
        {
            SunnyNetContext = Sunny.CreateSunnyNet();
        }
        ~SunnyNet()
        {
            //自动销毁
            Sunny.ReleaseSunnyNet(SunnyNetContext);
        }
        /// <summary>
        /// 导出已经设置的证书
        /// </summary>
        public String 导出证书()
        {
            IntPtr p = Sunny.ExportCert(SunnyNetContext);
            string a = Tool.PtrToString(p);
            Sunny.Free(p);//释放Sunny接收的指针
            return a;
        }

        /// <summary>
        /// 开启后SunnyNet不再对数据进行解密直接使用TCP发送，HTTPS的数据无法解码
        /// </summary>
        public void 强制客户端走TCP(bool open)
        {
            Sunny.SunnyNetMustTcp(SunnyNetContext, open);
        }


        /// <summary>
        /// 开启后客户端只能使用S5代理，并且输入设置的账号密码
        /// </summary>
        public void 身份验证模式_开启(bool open)
        {
            Sunny.SunnyNetVerifyUser(SunnyNetContext, open);
        }


        /// <summary>
        /// 开启 身份验证模式 后 添加用户名
        /// </summary>
        public bool 身份验证模式_添加用户(string user, string pass)
        {
            IntPtr _user = Tool.StringToIntptr(user);
            IntPtr _pass = Tool.StringToIntptr(pass);
            bool ret = Sunny.SunnyNetSocket5AddUser(SunnyNetContext, _user, _pass);
            Tool.PtrFree(_user);
            Tool.PtrFree(_pass);
            return ret;
        }


        /// <summary>
        /// 开启 身份验证模式 后 删除用户名
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool 身份验证模式_删除用户(string user)
        {
            IntPtr _user = Tool.StringToIntptr(user);
            bool ret = Sunny.SunnyNetSocket5DelUser(SunnyNetContext, _user);
            Tool.PtrFree(_user);

            return ret;
        }


        /// <summary>
        /// 开启身份验证模式后 获取授权的S5账号,注意UDP请求无法获取到授权的s5账号
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public String 身份验证模式_获取授权的S5账号(Int64 WeiYiId)
        {
            IntPtr ret = Sunny.SunnyNetGetSocket5User(WeiYiId);
            String a = Tool.PtrToString(ret);
            Sunny.Free(ret);//释放Sunny接收的指针
            return a;
        }

        /// <summary>
        /// 在启动之前调用
        /// </summary>
        public bool 绑定回调地址(System.Func<int, int, int, int, string, string, string, int, bool> 回调函数_HTTP请求 = null, System.Func<int, int, int, int, string, string, int, int, bool> 回调函数_WebSocket请求 = null, System.Func<int, string, string, int, int, IntPtr, int, int, int, bool> 回调函数_TCP请求 = null, System.Func<int, string, string, int, int, int, int, bool> 回调函数_UDP请求 = null)
        {
            HttpCALL = new NetHttpCallback(DefaultNetHttpCallback);
            TcpCALL = new NetTcpCallback(DefaultNetTcpCallback);
            WebsocketCALL = new NetWebsockCallback(DefaultNetWebsocketCallback);
            UdpCALL = new NetUDPCallback(DefaultNetUDPCallback);
            IntPtr t = Marshal.GetFunctionPointerForDelegate(TcpCALL);
            IntPtr h = Marshal.GetFunctionPointerForDelegate(HttpCALL);
            IntPtr w = Marshal.GetFunctionPointerForDelegate(WebsocketCALL);
            IntPtr u = Marshal.GetFunctionPointerForDelegate(UdpCALL);
            wsFunc = 回调函数_WebSocket请求;
            tcpFunc = 回调函数_TCP请求;
            httpFunc = 回调函数_HTTP请求;
            udpFunc = 回调函数_UDP请求;
            return Sunny.SunnyNetSetCallback(SunnyNetContext, h, t, w, u);
        }

        /// <summary>
        /// 在启动之前调用
        /// </summary>
        public bool 绑定端口(System.Int32 Port)
        {
            return Sunny.SunnyNetSetPort(SunnyNetContext, Port);
        }

        /// <summary>
        /// Sunny中间件可创建多个 由这个参数判断是哪个Sunny回调过来的
        /// </summary>
        public int 取SunnyNetContext()
        {
            return SunnyNetContext;
        }

        /// <summary>
        /// 启动前先绑定端口
        /// </summary>
        public bool 启动()
        {
            return Sunny.SunnyNetStart(SunnyNetContext);
        }

        /// <summary>
        /// 取消已经设置的IE代理
        /// </summary>
        public bool 关闭IE代理()
        {
            return Sunny.SetIeProxy(SunnyNetContext, true);
        }

        /// <summary>
        /// 设置当前绑定的端口号为当前IE代理 设置前请先绑定端口
        /// </summary>
        public bool 设置IE代理()
        {
            bool ret = Sunny.SetIeProxy(SunnyNetContext, false);
            return ret;
        }

        /// <summary>
        /// 停止的同时将会自动关闭IE代理
        /// </summary>
        public bool 停止代理()
        {
            return Sunny.SunnyNetClose(SunnyNetContext);
        }

        /// <summary>
        /// 导入自己的证书
        /// </summary>
        public bool 设置自定义CA证书(CertificateManager 证书管理器)
        {
            return Sunny.SunnyNetSetCert(SunnyNetContext, 证书管理器.获取证书Context());
        }


        /// <summary>
        /// 启动后调用,将中间件的证书安装到系统内
        /// </summary>
        public bool 安装证书()
        {
            IntPtr p = Sunny.SunnyNetInstallCert(SunnyNetContext);
            string err = Tool.PtrToString(p);
            Sunny.Free(p);//释放Sunny接收的指针
            if (err.IndexOf("添加到存储") != -1)
            {
                return true;
            }
            if (err.IndexOf("已经在存储中") != -1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取中间件启动时的错误信息
        /// </summary>
        public string 取错误()
        {
            IntPtr p = Sunny.SunnyNetError(SunnyNetContext);
            string a = Tool.PtrToStringUTF8(p);
            Sunny.Free(p);//释放Sunny接收的指针
            return a;
        }


        /// <summary>
        /// 设置上游代理 仅支持S5代理 或 http代理
        /// </summary>
        /// <param name="代理">仅支持Socket5和http 例如 socket5://admin:123456@127.0.0.1:8888 或 http://admin:123456@127.0.0.1:8888</param>
        /// <returns></returns> 
        public bool 设置上游代理(string 代理)
        {
            IntPtr _代理 = Tool.StringToIntptr(代理);
            bool ret = Sunny.SetGlobalProxy(SunnyNetContext, _代理);
            Tool.PtrFree(_代理);
            return ret;
        }

        /// <summary>
        ///  默认全部使用上游代理(只要设置了上游代理)
        /// </summary>
        /// <param name="规则">输入Host不带端口号;在此规则内的不使用上游代理 多个用";"分号或换行分割 例如"127.0.0.1;192.168.*.*"地址不使用上游代理</param>
        /// <returns></returns> 
        public bool 设置上游代理使用规则(string 规则)
        {
            IntPtr _规则 = Tool.StringToIntptr(规则);
            bool ret = Sunny.CompileProxyRegexp(SunnyNetContext, _规则);
            Tool.PtrFree(_规则);
            return ret;
        }

        /// <summary>
        ///  设置强制走TCP规则,如果 打开了全部强制走TCP状态,本功能则无效
        /// </summary>
        /// <param name="规则">在此规则内 多个用";"分号或换行分割 例如"127.0.0.1;192.168.*.*",强制使用TCP</param>
        /// <returns></returns> 
        public bool 设置强制TCP规则(string 规则)
        {
            IntPtr _规则 = Tool.StringToIntptr(规则);
            bool ret = Sunny.CompileProxyRegexp(SunnyNetContext, _规则);
            Tool.PtrFree(_规则);
            return ret;
        }

        /// <summary>
        /// 只允许一个中间件服务 加载驱动
        /// </summary>
        public bool 进程代理_加载驱动()
        {
            bool ret = Sunny.StartProcess(SunnyNetContext);
            return ret;
        }

        /// <summary>
        ///  添加指定的进程名进行捕获 [需调用 启动进程代理 后生效]
        ///  会强制断开此进程已经连接的TCP连接
        /// </summary>
        public void 进程代理_添加进程名(string 进程名)
        {
            IntPtr _进程名 = Tool.StringToIntptr(进程名);
            Sunny.ProcessAddName(SunnyNetContext, _进程名);
            Tool.PtrFree(_进程名);
        }

        /// <summary>
        ///  添加指定的进程PID进行捕获 [需调用 启动进程代理 后生效]
        ///  会强制断开此进程已经连接的TCP连接
        /// </summary>
        public void 进程代理_添加Pid(System.Int32 进程PID)
        {
            Sunny.ProcessAddPid(SunnyNetContext, 进程PID);
        }

        /// <summary>
        ///  删除指定的进程PID 停止捕获[需调用 启动进程代理 后生效]
        ///  会强制断开此进程已经连接的TCP连接
        /// </summary>
        public void 进程代理_删除Pid(System.Int32 进程PID)
        {
            Sunny.ProcessDelPid(SunnyNetContext, 进程PID);
        }

        /// <summary>
        /// 开启后 所有进程将会被捕获  [需调用 启动进程代理 后生效] 
        /// 会强制断开所有进程已经连接的TCP连接
        /// </summary>
        public void 进程代理_设置捕获任意进程(bool 开启)
        {
            Sunny.ProcessALLName(SunnyNetContext, 开启);
        }

        /// <summary>
        ///  删除指定的进程名 停止捕获[需调用 启动进程代理 后生效]
        ///  会强制断开此进程已经连接的TCP连接
        /// </summary>
        public void 进程代理_删除进程名(string 进程名)
        {
            IntPtr _进程名 = Tool.StringToIntptr(进程名);
            Sunny.ProcessDelName(SunnyNetContext, _进程名);
            Tool.PtrFree(_进程名);
        }

        /// <summary>
        ///  删除已设置的所有PID,进程名 [需调用 启动进程代理 后生效]
        ///  会强制断开所有进程已经连接的TCP连接
        /// </summary>
        public void 进程代理_删除全部()
        {
            Sunny.ProcessCancelAll(SunnyNetContext);
        }



    }
}
