using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace SunnyTest
{

    class Sunny
    {
        public static Request MessageIdToSunny(int MessageId)
        {
            Request request = new Request(MessageId);
            return request;
        }


        public static bool Is64BitProcess = Environment.Is64BitProcess;
        ////创建Sunny中间件对象,可创建多个
        public static System.Int32 CreateSunnyNet()
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_CreateSunnyNet();
            }
            else
            {
                return Sunny86.Sunny_CreateSunnyNet();
            }
        }

        //// ReleaseSunnyNet 释放SunnyNet
        public static bool ReleaseSunnyNet(System.Int32 SunnyContext)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_ReleaseSunnyNet(SunnyContext);
            }
            else
            {
                return Sunny86.Sunny_ReleaseSunnyNet(SunnyContext);
            }
        }

        ////启动Sunny中间件 成功返回true
        public static bool SunnyNetStart(System.Int32 SunnyContext)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SunnyNetStart(SunnyContext);
            }
            else
            {
                return Sunny86.Sunny_SunnyNetStart(SunnyContext);
            }
        }

        ////设置指定端口 Sunny中间件启动之前调用
        public static bool SunnyNetSetPort(System.Int32 SunnyContext, System.Int32 Port)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SunnyNetSetPort(SunnyContext, Port);
            }
            else
            {
                return Sunny86.Sunny_SunnyNetSetPort(SunnyContext, Port);
            }
        }


        ////关闭停止指定Sunny中间件
        public static bool SunnyNetClose(System.Int32 SunnyContext)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SunnyNetClose(SunnyContext);
            }
            else
            {
                return Sunny86.Sunny_SunnyNetClose(SunnyContext);
            }
        }

        ////设置请求超时
        public static void SetRequestOutTime(System.Int32 SunnyContext, System.Int32 times)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_SetRequestOutTime(SunnyContext, times);
            }
            else
            {
                Sunny86.Sunny_SetRequestOutTime(SunnyContext, times);
            }
        }
        ////设置自定义证书
        public static bool SunnyNetSetCert(System.Int32 SunnyContext, System.Int32 CertificateManagerId)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SunnyNetSetCert(SunnyContext, CertificateManagerId);
            }
            else
            {
                return Sunny86.Sunny_SunnyNetSetCert(SunnyContext, CertificateManagerId);
            }
        }

        ////安装证书 将证书安装到Windows系统内
        public static IntPtr SunnyNetInstallCert(System.Int32 SunnyContext)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SunnyNetInstallCert(SunnyContext);
            }
            else
            {
                return Sunny86.Sunny_SunnyNetInstallCert(SunnyContext);
            }
        }

        ////设置中间件回调地址 httpCallback
        public static bool SunnyNetSetCallback(System.Int32 SunnyContext, IntPtr httpCallback, IntPtr tcpCallback, IntPtr wsCallback, IntPtr udpCallback)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SunnyNetSetCallback(SunnyContext, httpCallback, tcpCallback, wsCallback, udpCallback);
            }
            else
            {
                return Sunny86.Sunny_SunnyNetSetCallback(SunnyContext, httpCallback, tcpCallback, wsCallback, udpCallback);
            }
        }

        ////添加 S5代理需要验证的用户名
        public static bool SunnyNetSocket5AddUser(System.Int32 SunnyContext, IntPtr User, IntPtr Pass)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SunnyNetSocket5AddUser(SunnyContext, User, Pass);
            }
            else
            {
                return Sunny86.Sunny_SunnyNetSocket5AddUser(SunnyContext, User, Pass);
            }
        }

        ////开启身份验证模式
        public static bool SunnyNetVerifyUser(System.Int32 SunnyContext, bool open)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SunnyNetVerifyUser(SunnyContext, open);
            }
            else
            {
                return Sunny86.Sunny_SunnyNetVerifyUser(SunnyContext, open);
            }
        }

        ////删除 S5需要验证的用户名
        public static bool SunnyNetSocket5DelUser(System.Int32 SunnyContext, IntPtr User)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SunnyNetSocket5DelUser(SunnyContext, User);
            }
            else
            {
                return Sunny86.Sunny_SunnyNetSocket5DelUser(SunnyContext, User);
            }
        }

        ////删除 S5需要验证的用户名
        public static IntPtr SunnyNetGetSocket5User(Int64 唯一ID)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SunnyNetGetSocket5User(唯一ID );
            }
            else
            {
                return Sunny86.Sunny_SunnyNetGetSocket5User((Int32)唯一ID );
            }
        }
        ////设置中间件是否开启强制走TCP
        public static void SunnyNetMustTcp(System.Int32 SunnyContext, bool open)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_SunnyNetMustTcp(SunnyContext, open);
            }
            else
            {
                Sunny86.Sunny_SunnyNetMustTcp(SunnyContext, open);
            }
        }

        ////设置中间件上游代理使用规则
        public static bool CompileProxyRegexp(System.Int32 SunnyContext, IntPtr Regexp)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_CompileProxyRegexp(SunnyContext, Regexp);
            }
            else
            {
                return Sunny86.Sunny_CompileProxyRegexp(SunnyContext, Regexp);
            }
        }

        ////获取中间件启动时的错误信息
        public static IntPtr SunnyNetError(System.Int32 SunnyContext)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SunnyNetError(SunnyContext);
            }
            else
            {
                return Sunny86.Sunny_SunnyNetError(SunnyContext);
            }
        }

        ////admin:123456@127.0.0.1:8888
        public static bool SetGlobalProxy(System.Int32 SunnyContext, IntPtr ProxyAddress)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetGlobalProxy(SunnyContext, ProxyAddress);
            }
            else
            {
                return Sunny86.Sunny_SetGlobalProxy(SunnyContext, ProxyAddress);
            }
        }

        //// 导出已设置的证书
        public static IntPtr ExportCert(System.Int32 SunnyContext)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_ExportCert(SunnyContext);
            }
            else
            {
                return Sunny86.Sunny_ExportCert(SunnyContext);
            }
        }

        ////设置IE代理 Off=true 取消 反之 设置 在中间件设置端口后调用
        public static bool SetIeProxy(System.Int32 SunnyContext, bool Off)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetIeProxy(SunnyContext, Off);
            }
            else
            {
                return Sunny86.Sunny_SetIeProxy(SunnyContext, Off);
            }
        }

        ////修改、设置 HTTP/S当前请求数据中指定Cookie
        public static void SetRequestCookie(System.Int32 MessageId, IntPtr name, IntPtr val)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_SetRequestCookie(MessageId, name, val);
            }
            else
            {
                Sunny86.Sunny_SetRequestCookie(MessageId, name, val);
            }
        }

        ////修改、设置 HTTP/S当前请求数据中的全部Cookie
        public static void SetRequestAllCookie(System.Int32 MessageId, IntPtr val)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_SetRequestAllCookie(MessageId, val);
            }
            else
            {
                Sunny86.Sunny_SetRequestAllCookie(MessageId, val);
            }
        }

        ////获取 HTTP/S当前请求数据中指定的Cookie
        public static IntPtr GetRequestCookie(System.Int32 MessageId, IntPtr name)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetRequestCookie(MessageId, name);
            }
            else
            {
                return Sunny86.Sunny_GetRequestCookie(MessageId, name);
            }
        }

        ////获取 HTTP/S 当前请求全部Cookie
        public static IntPtr GetRequestALLCookie(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetRequestALLCookie(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetRequestALLCookie(MessageId);
            }
        }

        ////删除HTTP/S返回数据中指定的协议头
        public static void DelResponseHeader(System.Int32 MessageId, IntPtr name)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_DelResponseHeader(MessageId, name);
            }
            else
            {
                Sunny86.Sunny_DelResponseHeader(MessageId, name);
            }
        }

        ////删除HTTP/S请求数据中指定的协议头
        public static void DelRequestHeader(System.Int32 MessageId, IntPtr name)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_DelRequestHeader(MessageId, name);
            }
            else
            {
                Sunny86.Sunny_DelRequestHeader(MessageId, name);
            }
        }

        ////设置HTTP/S请求体中的协议头
        public static void SetRequestHeader(System.Int32 MessageId, IntPtr name, IntPtr val)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_SetRequestHeader(MessageId, name, val);
            }
            else
            {
                Sunny86.Sunny_SetRequestHeader(MessageId, name, val);
            }
        }

        ////修改、设置 HTTP/S当前返回数据中的指定协议头
        public static void SetResponseHeader(System.Int32 MessageId, IntPtr name, IntPtr val)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_SetResponseHeader(MessageId, name, val);
            }
            else
            {
                Sunny86.Sunny_SetResponseHeader(MessageId, name, val);
            }
        }

        ////获取 HTTP/S当前请求数据中的指定协议头
        public static IntPtr GetRequestHeader(System.Int32 MessageId, IntPtr name)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetRequestHeader(MessageId, name);
            }
            else
            {
                return Sunny86.Sunny_GetRequestHeader(MessageId, name);
            }
        }

        ////获取 HTTP/S 当前返回数据中指定的协议头
        public static IntPtr GetResponseHeader(System.Int32 MessageId, IntPtr name)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetResponseHeader(MessageId, name);
            }
            else
            {
                return Sunny86.Sunny_GetResponseHeader(MessageId, name);
            }
        }

        ////修改、设置 HTTP/S当前返回数据中的全部协议头，例如设置返回两条Cookie 使用本命令设置 使用设置、修改 单条命令无效
        public static void SetResponseAllHeader(System.Int32 MessageId, IntPtr value)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_SetResponseAllHeader(MessageId, value);
            }
            else
            {
                Sunny86.Sunny_SetResponseAllHeader(MessageId, value);
            }
        }

        ////获取 HTTP/S 当前返回全部协议头
        public static IntPtr GetResponseAllHeader(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetResponseAllHeader(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetResponseAllHeader(MessageId);
            }
        }

        ////获取 HTTP/S 当前请求数据全部协议头
        public static IntPtr GetRequestAllHeader(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetRequestAllHeader(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetRequestAllHeader(MessageId);
            }
        }

        ////admin:123456@127.0.0.1:8888
        public static bool SetRequestProxy(System.Int32 MessageId, IntPtr ProxyUrl)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetRequestProxy(MessageId, ProxyUrl);
            }
            else
            {
                return Sunny86.Sunny_SetRequestProxy(MessageId, ProxyUrl);
            }
        }

        ////获取HTTP/S返回的状态码
        public static System.Int32 GetResponseStatusCode(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_GetResponseStatusCode(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetResponseStatusCode(MessageId);
            }
        }

        ////获取当前HTTP/S请求由哪个IP发起
        public static IntPtr GetRequestClientIp(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetRequestClientIp(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetRequestClientIp(MessageId);
            }
        }

        ////获取HTTP/S返回的状态文本 例如 [200 OK]
        public static IntPtr GetResponseStatus(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetResponseStatus(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetResponseStatus(MessageId);
            }
        }

        ////修改HTTP/S返回的状态码
        public static void SetResponseStatus(System.Int32 MessageId, System.Int32 code)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_SetResponseStatus(MessageId, code);
            }
            else
            {
                Sunny86.Sunny_SetResponseStatus(MessageId, code);
            }
        }

        ////修改HTTP/S当前请求的URL
        public static bool SetRequestUrl(System.Int32 MessageId, IntPtr URI)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetRequestUrl(MessageId, URI);
            }
            else
            {
                return Sunny86.Sunny_SetRequestUrl(MessageId, URI);
            }
        }

        ////获取 HTTP/S 当前请求POST提交数据长度
        public static System.Int32 GetRequestBodyLen(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_GetRequestBodyLen(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetRequestBodyLen(MessageId);
            }
        }

        ////获取 HTTP/S 当前返回  数据长度
        public static System.Int32 GetResponseBodyLen(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_GetResponseBodyLen(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetResponseBodyLen(MessageId);
            }
        }

        ////设置、修改 HTTP/S 当前请求返回数据 如果再发起请求时调用本命令，请求将不会被发送，将会直接返回 data=数据指针  dataLen=数据长度
        public static bool SetResponseData(System.Int32 MessageId, IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetResponseData(MessageId, data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_SetResponseData(MessageId, data, dataLen);
            }
        }

        ////设置、修改 HTTP/S 当前请求POST提交数据  data=数据指针  dataLen=数据长度
        public static System.Int32 SetRequestData(System.Int32 MessageId, IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_SetRequestData(MessageId, data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_SetRequestData(MessageId, data, dataLen);
            }
        }

        ////获取 HTTP/S 当前POST提交数据 返回 数据指针
        public static IntPtr GetRequestBody(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetRequestBody(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetRequestBody(MessageId);
            }
        }

        ////获取 HTTP/S 当前返回数据  返回 数据指针
        public static IntPtr GetResponseBody(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetResponseBody(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetResponseBody(MessageId);
            }
        }

        ////获取 WebSocket消息长度
        public static System.Int32 GetWebsocketBodyLen(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_GetWebsocketBodyLen(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetWebsocketBodyLen(MessageId);
            }
        }

        ////获取 WebSocket消息 返回数据指针
        public static IntPtr GetWebsocketBody(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetWebsocketBody(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetWebsocketBody(MessageId);
            }
        }

        ////修改 WebSocket消息 data=数据指针  dataLen=数据长度
        public static bool SetWebsocketBody(System.Int32 MessageId, IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetWebsocketBody(MessageId, data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_SetWebsocketBody(MessageId, data, dataLen);
            }
        }

        ////主动向Websocket服务器发送消息 MessageType=WS消息类型 data=数据指针  dataLen=数据长度
        public static bool SendWebsocketBody(System.Int32 唯一ID, System.Int32 MessageType, IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SendWebsocketBody(唯一ID, MessageType, data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_SendWebsocketBody(唯一ID, MessageType, data, dataLen);
            }
        }
        ////主动向Websocket客户端发送消息 TheologyID=唯一ID MessageType=WS消息类型 data=数据指针  dataLen=数据长度
        public static bool SendWebsocketClientBody(System.Int32 TheologyID, System.Int32 MessageType, IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SendWebsocketClientBody(TheologyID, MessageType, data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_SendWebsocketClientBody(TheologyID, MessageType, data, dataLen);
            }
        }
        ////根据唯一ID关闭指定的Websocket连接  唯一ID在回调参数中
        public static bool CloseWebsocket(System.Int32 theology)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_CloseWebsocket(theology);
            }
            else
            {
                return Sunny86.Sunny_CloseWebsocket(theology);
            }
        }
        ////修改 TCP消息数据 MsgType=1 发送的消息 MsgType=2 接收的消息 如果 MsgType和MessageId不匹配，将不会执行操作  data=数据指针  dataLen=数据长度
        public static bool SetTcpBody(System.Int32 MessageId, System.Int32 MsgType, IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetTcpBody(MessageId, MsgType, data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_SetTcpBody(MessageId, MsgType, data, dataLen);
            }
        }

        ////admin:123456@127.0.0.1:8888
        public static bool SetTcpAgent(System.Int32 MessageId, IntPtr ProxyUrl)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetTcpAgent(MessageId, ProxyUrl);
            }
            else
            {
                return Sunny86.Sunny_SetTcpAgent(MessageId, ProxyUrl);
            }
        }

        ////根据唯一ID关闭指定的TCP连接  唯一ID在回调参数中
        public static bool TcpCloseClient(System.Int32 theology)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_TcpCloseClient(theology);
            }
            else
            {
                return Sunny86.Sunny_TcpCloseClient(theology);
            }
        }

        ////给指定的TCP连接 修改目标连接地址 目标地址必须带端口号 例如 baidu.com:443
        public static bool SetTcpConnectionIP(System.Int32 MessageId, IntPtr address)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetTcpConnectionIP(MessageId, address);
            }
            else
            {
                return Sunny86.Sunny_SetTcpConnectionIP(MessageId, address);
            }
        }

        ////指定的TCP连接 模拟客户端向服务器端主动发送数据
        public static System.Int32 TcpSendMsg(System.Int32 theology, IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_TcpSendMsg(theology, data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_TcpSendMsg(theology, data, dataLen);
            }
        }

        ////指定的TCP连接 模拟服务器端向客户端主动发送数据
        public static System.Int32 TcpSendMsgClient(System.Int32 theology, IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_TcpSendMsgClient(theology, data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_TcpSendMsgClient(theology, data, dataLen);
            }
        }

        //
        public static IntPtr HexDump(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_HexDump(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_HexDump(data, dataLen);
            }
        }

        ////将Go int的Bytes 转为int
        public static System.Int32 BytesToInt(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_BytesToInt(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_BytesToInt(data, dataLen);
            }
        }

        ////Gzip解压缩
        public static IntPtr GzipUnCompress(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GzipUnCompress(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_GzipUnCompress(data, dataLen);
            }
        }

        ////br解压缩
        public static IntPtr BrUnCompress(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_BrUnCompress(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_BrUnCompress(data, dataLen);
            }
        }

        ////br压缩
        public static IntPtr BrCompress(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_BrCompress(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_BrCompress(data, dataLen);
            }
        }

        ////br压缩
        public static IntPtr BrotliCompress(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_BrotliCompress(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_BrotliCompress(data, dataLen);
            }
        }

        ////Gzip压缩
        public static IntPtr GzipCompress(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GzipCompress(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_GzipCompress(data, dataLen);
            }
        }

        ////Zlib压缩
        public static IntPtr ZlibCompress(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_ZlibCompress(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_ZlibCompress(data, dataLen);
            }
        }

        ////Zlib解压缩
        public static IntPtr ZlibUnCompress(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_ZlibUnCompress(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_ZlibUnCompress(data, dataLen);
            }
        }

        ////Deflate解压缩 (可能等同于zlib解压缩)
        public static IntPtr DeflateUnCompress(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_DeflateUnCompress(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_DeflateUnCompress(data, dataLen);
            }
        }

        ////Deflate压缩 (可能等同于zlib压缩)
        public static IntPtr DeflateCompress(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_DeflateCompress(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_DeflateCompress(data, dataLen);
            }
        }

        ////Webp图片转JEG图片字节数组 SaveQuality=质量(默认75)
        public static IntPtr WebpToJpegBytes(IntPtr data, System.Int32 dataLen, System.Int32 SaveQuality)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_WebpToJpegBytes(data, dataLen, SaveQuality);
            }
            else
            {
                return Sunny86.Sunny_WebpToJpegBytes(data, dataLen, SaveQuality);
            }
        }

        ////Webp图片转Png图片字节数组
        public static IntPtr WebpToPngBytes(IntPtr data, System.Int32 dataLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_WebpToPngBytes(data, dataLen);
            }
            else
            {
                return Sunny86.Sunny_WebpToPngBytes(data, dataLen);
            }
        }

        ////Webp图片转JEG图片 根据文件名 SaveQuality=质量(默认75)
        public static bool WebpToJpeg(IntPtr webpPath, IntPtr savePath, System.Int32 SaveQuality)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_WebpToJpeg(webpPath, savePath, SaveQuality);
            }
            else
            {
                return Sunny86.Sunny_WebpToJpeg(webpPath, savePath, SaveQuality);
            }
        }

        ////Webp图片转Png图片 根据文件名
        public static bool WebpToPng(IntPtr webpPath, IntPtr savePath)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_WebpToPng(webpPath, savePath);
            }
            else
            {
                return Sunny86.Sunny_WebpToPng(webpPath, savePath);
            }
        }

        ////适配火山PC CALL 火山直接CALL X64没有问题，X86环境下有问题，所以搞了这个命令
        public static System.Int32 GoCall(System.Int32 address, System.Int32 a1, System.Int32 a2, System.Int32 a3, System.Int32 a4, System.Int32 a5, System.Int32 a6, System.Int32 a7, System.Int32 a8, System.Int32 a9)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_GoCall(address, a1, a2, a3, a4, a5, a6, a7, a8, a9);
            }
            else
            {
                return Sunny86.Sunny_GoCall(address, a1, a2, a3, a4, a5, a6, a7, a8, a9);
            }
        }

        ////执行JS代码执行前 先调用 SetScript  设置JS代码
        public static IntPtr ScriptCall(System.Int32 i, IntPtr Request)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_ScriptCall(i, Request);
            }
            else
            {
                return Sunny86.Sunny_ScriptCall(i, Request);
            }
        }

        ////设置JS代码
        public static IntPtr SetScript(IntPtr Request)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetScript(Request);
            }
            else
            {
                return Sunny86.Sunny_SetScript(Request);
            }
        }

        ////设置JSLog函数回调地址
        public static void SetScriptLogCallAddress(IntPtr i)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_SetScriptLogCallAddress(i);
            }
            else
            {
                Sunny86.Sunny_SetScriptLogCallAddress(i);
            }
        }

        ////开启进程代理 加载 nf api 驱动
        public static bool StartProcess(System.Int32 SunnyContext)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_StartProcess(SunnyContext);
            }
            else
            {
                return Sunny86.Sunny_StartProcess(SunnyContext);
            }
        }

        ////进程代理 添加进程名
        public static void ProcessAddName(System.Int32 SunnyContext, IntPtr Name)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_ProcessAddName(SunnyContext, Name);
            }
            else
            {
                Sunny86.Sunny_ProcessAddName(SunnyContext, Name);
            }
        }

        ////进程代理 删除进程名
        public static void ProcessDelName(System.Int32 SunnyContext, IntPtr Name)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_ProcessDelName(SunnyContext, Name);
            }
            else
            {
                Sunny86.Sunny_ProcessDelName(SunnyContext, Name);
            }
        }

        ////进程代理 添加PID
        public static void ProcessAddPid(System.Int32 SunnyContext, System.Int32 pid)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_ProcessAddPid(SunnyContext, pid);
            }
            else
            {
                Sunny86.Sunny_ProcessAddPid(SunnyContext, pid);
            }
        }

        ////进程代理 删除PID
        public static void ProcessDelPid(System.Int32 SunnyContext, System.Int32 pid)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_ProcessDelPid(SunnyContext, pid);
            }
            else
            {
                Sunny86.Sunny_ProcessDelPid(SunnyContext, pid);
            }
        }

        ////进程代理 取消全部已设置的进程名
        public static void ProcessCancelAll(System.Int32 SunnyContext)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_ProcessCancelAll(SunnyContext);
            }
            else
            {
                Sunny86.Sunny_ProcessCancelAll(SunnyContext);
            }
        }

        ////进程代理 设置是否全部进程通过
        public static void ProcessALLName(System.Int32 SunnyContext, bool open)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_ProcessALLName(SunnyContext, open);
            }
            else
            {
                Sunny86.Sunny_ProcessALLName(SunnyContext, open);
            }
        }

        ////证书管理器 获取证书 CommonName 字段
        public static IntPtr GetCommonName(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetCommonName(Context);
            }
            else
            {
                return Sunny86.Sunny_GetCommonName(Context);
            }
        }

        ////证书管理器 导出为P12
        public static bool ExportP12(System.Int32 Context, IntPtr path, IntPtr pass)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_ExportP12(Context, path, pass);
            }
            else
            {
                return Sunny86.Sunny_ExportP12(Context, path, pass);
            }
        }

        ////证书管理器 导出公钥
        public static IntPtr ExportPub(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_ExportPub(Context);
            }
            else
            {
                return Sunny86.Sunny_ExportPub(Context);
            }
        }

        ////证书管理器 导出私钥
        public static IntPtr ExportKEY(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_ExportKEY(Context);
            }
            else
            {
                return Sunny86.Sunny_ExportKEY(Context);
            }
        }

        ////证书管理器 导出证书
        public static IntPtr ExportCA(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_ExportCA(Context);
            }
            else
            {
                return Sunny86.Sunny_ExportCA(Context);
            }
        }

        ////证书管理器 创建证书
        public static bool CreateCA(System.Int32 Context, IntPtr Country, IntPtr Organization, IntPtr OrganizationalUnit, IntPtr Province, IntPtr CommonName, IntPtr Locality, System.Int32 bits, System.Int32 NotAfter)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_CreateCA(Context, Country, Organization, OrganizationalUnit, Province, CommonName, Locality, bits, NotAfter);
            }
            else
            {
                return Sunny86.Sunny_CreateCA(Context, Country, Organization, OrganizationalUnit, Province, CommonName, Locality, bits, NotAfter);
            }
        }

        ////证书管理器 设置ClientAuth
        public static bool AddClientAuth(System.Int32 Context, System.Int32 val)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_AddClientAuth(Context, val);
            }
            else
            {
                return Sunny86.Sunny_AddClientAuth(Context, val);
            }
        }

        ////证书管理器 设置信任的证书 从 文本
        public static bool AddCertPoolText(System.Int32 Context, IntPtr cer)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_AddCertPoolText(Context, cer);
            }
            else
            {
                return Sunny86.Sunny_AddCertPoolText(Context, cer);
            }
        }

        ////证书管理器 设置信任的证书 从 文件
        public static bool AddCertPoolPath(System.Int32 Context, IntPtr cer)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_AddCertPoolPath(Context, cer);
            }
            else
            {
                return Sunny86.Sunny_AddCertPoolPath(Context, cer);
            }
        }

        ////证书管理器 取ServerName
        public static IntPtr GetServerName(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetServerName(Context);
            }
            else
            {
                return Sunny86.Sunny_GetServerName(Context);
            }
        }

        ////证书管理器 设置ServerName
        public static bool SetServerName(System.Int32 Context, IntPtr name)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetServerName(Context, name);
            }
            else
            {
                return Sunny86.Sunny_SetServerName(Context, name);
            }
        }

        ////证书管理器 设置跳过主机验证
        public static bool SetInsecureSkipVerify(System.Int32 Context, bool b)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetInsecureSkipVerify(Context, b);
            }
            else
            {
                return Sunny86.Sunny_SetInsecureSkipVerify(Context, b);
            }
        }

        ////证书管理器 载入X509证书
        public static bool LoadX509Certificate(System.Int32 Context, IntPtr Host, IntPtr CA, IntPtr KEY)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_LoadX509Certificate(Context, Host, CA, KEY);
            }
            else
            {
                return Sunny86.Sunny_LoadX509Certificate(Context, Host, CA, KEY);
            }
        }

        ////证书管理器 载入X509证书2
        public static bool LoadX509KeyPair(System.Int32 Context, IntPtr CaPath, IntPtr KeyPath)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_LoadX509KeyPair(Context, CaPath, KeyPath);
            }
            else
            {
                return Sunny86.Sunny_LoadX509KeyPair(Context, CaPath, KeyPath);
            }
        }

        ////证书管理器 载入p12证书
        public static bool LoadP12Certificate(System.Int32 Context, IntPtr Name, IntPtr Password)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_LoadP12Certificate(Context, Name, Password);
            }
            else
            {
                return Sunny86.Sunny_LoadP12Certificate(Context, Name, Password);
            }
        }

        ////释放 证书管理器 对象
        public static void RemoveCertificate(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_RemoveCertificate(Context);
            }
            else
            {
                Sunny86.Sunny_RemoveCertificate(Context);
            }
        }

        ////创建 证书管理器 对象
        public static System.Int32 CreateCertificate()
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_CreateCertificate();
            }
            else
            {
                return Sunny86.Sunny_CreateCertificate();
            }
        }

        ////GoMap 写字符串
        public static void KeysWriteStr(System.Int32 KeysHandle, IntPtr name, IntPtr val, System.Int32 len)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_KeysWriteStr(KeysHandle, name, val, len);
            }
            else
            {
                Sunny86.Sunny_KeysWriteStr(KeysHandle, name, val, len);
            }
        }

        ////GoMap 转为JSON字符串
        public static IntPtr KeysGetJson(System.Int32 KeysHandle)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_KeysGetJson(KeysHandle);
            }
            else
            {
                return Sunny86.Sunny_KeysGetJson(KeysHandle);
            }
        }

        ////GoMap 取数量
        public static System.Int32 KeysGetCount(System.Int32 KeysHandle)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_KeysGetCount(KeysHandle);
            }
            else
            {
                return Sunny86.Sunny_KeysGetCount(KeysHandle);
            }
        }

        ////GoMap 清空
        public static void KeysEmpty(System.Int32 KeysHandle)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_KeysEmpty(KeysHandle);
            }
            else
            {
                Sunny86.Sunny_KeysEmpty(KeysHandle);
            }
        }

        ////GoMap 读整数
        public static System.Int32 KeysReadInt(System.Int32 KeysHandle, IntPtr name)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_KeysReadInt(KeysHandle, name);
            }
            else
            {
                return Sunny86.Sunny_KeysReadInt(KeysHandle, name);
            }
        }

        ////GoMap 写整数
        public static void KeysWriteInt(System.Int32 KeysHandle, IntPtr name, System.Int32 val)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_KeysWriteInt(KeysHandle, name, val);
            }
            else
            {
                Sunny86.Sunny_KeysWriteInt(KeysHandle, name, val);
            }
        }

        ////GoMap 读长整数
        public static Int64 KeysReadLong(System.Int32 KeysHandle, IntPtr name)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_KeysReadLong(KeysHandle, name);
            }
            else
            {
                return Sunny86.Sunny_KeysReadLong(KeysHandle, name);
            }
        }

        ////GoMap 写长整数
        public static void KeysWriteLong(System.Int32 KeysHandle, IntPtr name, Int64 val)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_KeysWriteLong(KeysHandle, name, val);
            }
            else
            {
                Sunny86.Sunny_KeysWriteLong(KeysHandle, name, val);
            }
        }

        ////GoMap 读浮点数
        public static Double KeysReadFloat(System.Int32 KeysHandle, IntPtr name)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_KeysReadFloat(KeysHandle, name);
            }
            else
            {
                return Sunny86.Sunny_KeysReadFloat(KeysHandle, name);
            }
        }

        ////GoMap 写浮点数
        public static void KeysWriteFloat(System.Int32 KeysHandle, IntPtr name, Double val)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_KeysWriteFloat(KeysHandle, name, val);
            }
            else
            {
                Sunny86.Sunny_KeysWriteFloat(KeysHandle, name, val);
            }
        }

        ////GoMap 写字节数组
        public static void KeysWrite(System.Int32 KeysHandle, IntPtr name, IntPtr val, System.Int32 length)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_KeysWrite(KeysHandle, name, val, length);
            }
            else
            {
                Sunny86.Sunny_KeysWrite(KeysHandle, name, val, length);
            }
        }

        ////GoMap 写读字符串/字节数组
        public static IntPtr KeysRead(System.Int32 KeysHandle, IntPtr name)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_KeysRead(KeysHandle, name);
            }
            else
            {
                return Sunny86.Sunny_KeysRead(KeysHandle, name);
            }
        }

        ////GoMap 删除
        public static void KeysDelete(System.Int32 KeysHandle, IntPtr name)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_KeysDelete(KeysHandle, name);
            }
            else
            {
                Sunny86.Sunny_KeysDelete(KeysHandle, name);
            }
        }

        ////GoMap 删除GoMap
        public static void RemoveKeys(System.Int32 KeysHandle)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_RemoveKeys(KeysHandle);
            }
            else
            {
                Sunny86.Sunny_RemoveKeys(KeysHandle);
            }
        }

        ////GoMap 创建
        public static System.Int32 CreateKeys()
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_CreateKeys();
            }
            else
            {
                return Sunny86.Sunny_CreateKeys();
            }
        }

        ////HTTP 客户端 设置重定向
        public static bool HTTPSetRedirect(System.Int32 Context, bool Redirect)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_HTTPSetRedirect(Context, Redirect);
            }
            else
            {
                return Sunny86.Sunny_HTTPSetRedirect(Context, Redirect);
            }
        }

        ////HTTP 客户端 返回响应状态码
        public static System.Int32 HTTPGetCode(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_HTTPGetCode(Context);
            }
            else
            {
                return Sunny86.Sunny_HTTPGetCode(Context);
            }
        }

        ////HTTP 客户端 返回响应内容
        public static IntPtr HTTPGetBody(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_HTTPGetBody(Context);
            }
            else
            {
                return Sunny86.Sunny_HTTPGetBody(Context);
            }
        }

        ////HTTP 客户端 返回响应全部Heads
        public static IntPtr HTTPGetHeads(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_HTTPGetHeads(Context);
            }
            else
            {
                return Sunny86.Sunny_HTTPGetHeads(Context);
            }
        }

        ////HTTP 客户端 返回响应长度
        public static System.Int32 HTTPGetBodyLen(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_HTTPGetBodyLen(Context);
            }
            else
            {
                return Sunny86.Sunny_HTTPGetBodyLen(Context);
            }
        }

        ////HTTP 客户端 发送Body
        public static void HTTPSendBin(System.Int32 Context, IntPtr body, System.Int32 bodyLength)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_HTTPSendBin(Context, body, bodyLength);
            }
            else
            {
                Sunny86.Sunny_HTTPSendBin(Context, body, bodyLength);
            }
        }

        ////HTTP 客户端 设置超时 毫秒
        public static void HTTPSetTimeouts(System.Int32 Context, System.Int32 t1, System.Int32 t2, System.Int32 t3)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_HTTPSetTimeouts(Context, t1, t2, t3);
            }
            else
            {
                Sunny86.Sunny_HTTPSetTimeouts(Context, t1, t2, t3);
            }
        }

        ////HTTP 客户端 设置代理IP 仅支持Socket5和http 例如 socket5://admin:123456@127.0.0.1:8888 或 http://admin:123456@127.0.0.1:8888
        public static void HTTPSetProxyIP(System.Int32 Context, IntPtr ProxyURL)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_HTTPSetProxyIP(Context, ProxyURL);
            }
            else
            {
                Sunny86.Sunny_HTTPSetProxyIP(Context, ProxyURL);
            }
        }

        ////HTTP 客户端 设置协议头
        public static void HTTPSetHeader(System.Int32 Context, IntPtr name, IntPtr value)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_HTTPSetHeader(Context, name, value);
            }
            else
            {
                Sunny86.Sunny_HTTPSetHeader(Context, name, value);
            }
        }



        ////HTTP 客户端 设置证书管理器
        public static bool HTTPSetCertManager(System.Int32 Context, System.Int32 CertManagerContext)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_HTTPSetCertManager(Context, CertManagerContext);
            }
            else
            {
                return Sunny86.Sunny_HTTPSetCertManager(Context, CertManagerContext);
            }
        }

        ////HTTP 客户端 Open
        public static void HTTPOpen(System.Int32 Context, IntPtr Method, IntPtr URL)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_HTTPOpen(Context, Method, URL);
            }
            else
            {
                Sunny86.Sunny_HTTPOpen(Context, Method, URL);
            }
        }

        ////HTTP 客户端 取错误
        public static IntPtr HTTPClientGetErr(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_HTTPClientGetErr(Context);
            }
            else
            {
                return Sunny86.Sunny_HTTPClientGetErr(Context);
            }
        }

        ////释放 HTTP客户端
        public static void RemoveHTTPClient(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_RemoveHTTPClient(Context);
            }
            else
            {
                Sunny86.Sunny_RemoveHTTPClient(Context);
            }
        }

        ////创建 HTTP 客户端
        public static System.Int32 CreateHTTPClient()
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_CreateHTTPClient();
            }
            else
            {
                return Sunny86.Sunny_CreateHTTPClient();
            }
        }

        ////JSON格式的protobuf数据转为protobuf二进制数据
        public static IntPtr JsonToPB(IntPtr bin, System.Int32 binLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_JsonToPB(bin, binLen);
            }
            else
            {
                return Sunny86.Sunny_JsonToPB(bin, binLen);
            }
        }

        ////protobuf数据转为JSON格式
        public static IntPtr PbToJson(IntPtr bin, System.Int32 binLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_PbToJson(bin, binLen);
            }
            else
            {
                return Sunny86.Sunny_PbToJson(bin, binLen);
            }
        }

        ////队列弹出
        public static IntPtr QueuePull(IntPtr name)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_QueuePull(name);
            }
            else
            {
                return Sunny86.Sunny_QueuePull(name);
            }
        }

        ////加入队列
        public static void QueuePush(IntPtr name, IntPtr val, System.Int32 valLen)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_QueuePush(name, val, valLen);
            }
            else
            {
                Sunny86.Sunny_QueuePush(name, val, valLen);
            }
        }

        ////取队列长度
        public static System.Int32 QueueLength(IntPtr name)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_QueueLength(name);
            }
            else
            {
                return Sunny86.Sunny_QueueLength(name);
            }
        }

        ////清空销毁队列
        public static void QueueRelease(IntPtr name)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_QueueRelease(name);
            }
            else
            {
                Sunny86.Sunny_QueueRelease(name);
            }
        }

        ////队列是否为空
        public static bool QueueIsEmpty(IntPtr name)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_QueueIsEmpty(name);
            }
            else
            {
                return Sunny86.Sunny_QueueIsEmpty(name);
            }
        }

        ////创建队列
        public static void CreateQueue(IntPtr name)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_CreateQueue(name);
            }
            else
            {
                Sunny86.Sunny_CreateQueue(name);
            }
        }

        ////TCP客户端 发送数据
        public static System.Int32 SocketClientWrite(System.Int32 Context, System.Int32 OutTimes, IntPtr val, System.Int32 valLen)
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_SocketClientWrite(Context, OutTimes, val, valLen);
            }
            else
            {
                return Sunny86.Sunny_SocketClientWrite(Context, OutTimes, val, valLen);
            }
        }

        ////TCP客户端 断开连接
        public static void SocketClientClose(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_SocketClientClose(Context);
            }
            else
            {
                Sunny86.Sunny_SocketClientClose(Context);
            }
        }

        ////TCP客户端 同步模式下 接收数据
        public static IntPtr SocketClientReceive(System.Int32 Context, System.Int32 OutTimes)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SocketClientReceive(Context, OutTimes);
            }
            else
            {
                return Sunny86.Sunny_SocketClientReceive(Context, OutTimes);
            }
        }

        ////TCP客户端 连接
        public static bool SocketClientDial(System.Int32 Context, IntPtr addr, IntPtr call, bool isTls, bool synchronous, IntPtr ProxyUrl, System.Int32 CertificateConText)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SocketClientDial(Context, addr, call, isTls, synchronous, ProxyUrl, CertificateConText);
            }
            else
            {
                return Sunny86.Sunny_SocketClientDial(Context, addr, call, isTls, synchronous, ProxyUrl, CertificateConText);
            }
        }

        ////TCP客户端 置缓冲区大小
        public static bool SocketClientSetBufferSize(System.Int32 Context, System.Int32 BufferSize)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SocketClientSetBufferSize(Context, BufferSize);
            }
            else
            {
                return Sunny86.Sunny_SocketClientSetBufferSize(Context, BufferSize);
            }
        }

        ////TCP客户端 取错误
        public static IntPtr SocketClientGetErr(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SocketClientGetErr(Context);
            }
            else
            {
                return Sunny86.Sunny_SocketClientGetErr(Context);
            }
        }

        ////释放 TCP客户端
        public static void RemoveSocketClient(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_RemoveSocketClient(Context);
            }
            else
            {
                Sunny86.Sunny_RemoveSocketClient(Context);
            }
        }

        ////创建 TCP客户端
        public static System.Int32 CreateSocketClient()
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_CreateSocketClient();
            }
            else
            {
                return Sunny86.Sunny_CreateSocketClient();
            }
        }

        ////Websocket客户端 同步模式下 接收数据 返回数据指针 失败返回0 length=返回数据长度
        public static IntPtr WebsocketClientReceive(System.Int32 Context, System.Int32 OutTimes)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_WebsocketClientReceive(Context, OutTimes);
            }
            else
            {
                return Sunny86.Sunny_WebsocketClientReceive(Context, OutTimes);
            }
        }

        ////Websocket客户端  发送数据
        public static bool WebsocketReadWrite(System.Int32 Context, IntPtr val, System.Int32 valLen, System.Int32 messageType)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_WebsocketReadWrite(Context, val, valLen, messageType);
            }
            else
            {
                return Sunny86.Sunny_WebsocketReadWrite(Context, val, valLen, messageType);
            }
        }

        ////Websocket客户端 断开
        public static void WebsocketClose(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_WebsocketClose(Context);
            }
            else
            {
                Sunny86.Sunny_WebsocketClose(Context);
            }
        }

        ////Websocket客户端 连接
        public static bool WebsocketDial(System.Int32 Context, IntPtr URL, IntPtr Heads, IntPtr call, bool synchronous, IntPtr ProxyUrl, System.Int32 CertificateConText, System.Int32 outTime )
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_WebsocketDial(Context, URL, Heads, call, synchronous, ProxyUrl, CertificateConText, outTime);
            }
            else
            {
                return Sunny86.Sunny_WebsocketDial(Context, URL, Heads, call, synchronous, ProxyUrl, CertificateConText, outTime);
            }
        }

        ////Websocket客户端 获取错误
        public static IntPtr WebsocketGetErr(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_WebsocketGetErr(Context);
            }
            else
            {
                return Sunny86.Sunny_WebsocketGetErr(Context);
            }
        }

        ////释放 Websocket客户端 对象
        public static void RemoveWebsocket(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_RemoveWebsocket(Context);
            }
            else
            {
                Sunny86.Sunny_RemoveWebsocket(Context);
            }
        }

        ////创建 Websocket客户端 对象
        public static System.Int32 CreateWebsocket()
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_CreateWebsocket();
            }
            else
            {
                return Sunny86.Sunny_CreateWebsocket();
            }
        }

        ////创建 Http证书管理器 对象 实现指定Host使用指定证书
        public static bool AddHttpCertificate(IntPtr host, System.Int32 CertManagerId, System.Int32 Rules)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_AddHttpCertificate(host, CertManagerId, Rules);
            }
            else
            {
                return Sunny86.Sunny_AddHttpCertificate(host, CertManagerId, Rules);
            }
        }

        ////删除 Http证书管理器 对象
        public static void DelHttpCertificate(IntPtr host)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_DelHttpCertificate(host);
            }
            else
            {
                Sunny86.Sunny_DelHttpCertificate(host);
            }
        }

        //// Redis 订阅消息
        public static void RedisSubscribe(System.Int32 Context, IntPtr scribe, System.Int32 call, bool nc)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_RedisSubscribe(Context, scribe, call, nc);
            }
            else
            {
                Sunny86.Sunny_RedisSubscribe(Context, scribe, call, nc);
            }
        }

        //// Redis 删除
        public static bool RedisDelete(System.Int32 Context, IntPtr key)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_RedisDelete(Context, key);
            }
            else
            {
                return Sunny86.Sunny_RedisDelete(Context, key);
            }
        }

        //// Redis 清空当前数据库
        public static void RedisFlushDB(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_RedisFlushDB(Context);
            }
            else
            {
                Sunny86.Sunny_RedisFlushDB(Context);
            }
        }

        //// Redis 清空redis服务器
        public static void RedisFlushAll(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_RedisFlushAll(Context);
            }
            else
            {
                Sunny86.Sunny_RedisFlushAll(Context);
            }
        }

        //// Redis 关闭
        public static void RedisClose(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_RedisClose(Context);
            }
            else
            {
                Sunny86.Sunny_RedisClose(Context);
            }
        }

        //// Redis 取整数值
        public static Int64 RedisGetInt(System.Int32 Context, IntPtr key)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_RedisGetInt(Context, key);
            }
            else
            {
                return Sunny86.Sunny_RedisGetInt(Context, key);
            }
        }

        //// Redis 取指定条件键名
        public static IntPtr RedisGetKeys(System.Int32 Context, IntPtr key)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_RedisGetKeys(Context, key);
            }
            else
            {
                return Sunny86.Sunny_RedisGetKeys(Context, key);
            }
        }

        //// Redis 自定义 执行和查询命令 返回操作结果可能是值 也可能是JSON文本
        public static IntPtr RedisDo(System.Int32 Context, IntPtr args, IntPtr error)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_RedisDo(Context, args, error);
            }
            else
            {
                return Sunny86.Sunny_RedisDo(Context, args, error);
            }
        }

        //// Redis 取文本值
        public static IntPtr RedisGetStr(System.Int32 Context, IntPtr key)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_RedisGetStr(Context, key);
            }
            else
            {
                return Sunny86.Sunny_RedisGetStr(Context, key);
            }
        }

        //// Redis 取Bytes值
        public static IntPtr RedisGetBytes(System.Int32 Context, IntPtr key)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_RedisGetBytes(Context, key);
            }
            else
            {
                return Sunny86.Sunny_RedisGetBytes(Context, key);
            }
        }

        //// Redis 检查指定 key 是否存在
        public static bool RedisExists(System.Int32 Context, IntPtr key)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_RedisExists(Context, key);
            }
            else
            {
                return Sunny86.Sunny_RedisExists(Context, key);
            }
        }

        //// Redis 设置NX 【如果键名存在返回假】
        public static bool RedisSetNx(System.Int32 Context, IntPtr key, IntPtr val, System.Int32 expr)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_RedisSetNx(Context, key, val, expr);
            }
            else
            {
                return Sunny86.Sunny_RedisSetNx(Context, key, val, expr);
            }
        }

        //// Redis 设置值
        public static bool RedisSet(System.Int32 Context, IntPtr key, IntPtr val, System.Int32 expr)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_RedisSet(Context, key, val, expr);
            }
            else
            {
                return Sunny86.Sunny_RedisSet(Context, key, val, expr);
            }
        }

        //// Redis 设置Bytes值
        public static bool RedisSetBytes(System.Int32 Context, IntPtr key, IntPtr val, System.Int32 valLen, System.Int32 expr)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_RedisSetBytes(Context, key, val, valLen, expr);
            }
            else
            {
                return Sunny86.Sunny_RedisSetBytes(Context, key, val, valLen, expr);
            }
        }

        //// Redis 连接
        public static bool RedisDial(System.Int32 Context, IntPtr host, IntPtr pass, System.Int32 db, System.Int32 PoolSize, System.Int32 MinIdleCons, System.Int32 DialTimeout, System.Int32 ReadTimeout, System.Int32 WriteTimeout, System.Int32 PoolTimeout, System.Int32 IdleCheckFrequency, System.Int32 IdleTimeout, IntPtr error)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_RedisDial(Context, host, pass, db, PoolSize, MinIdleCons, DialTimeout, ReadTimeout, WriteTimeout, PoolTimeout, IdleCheckFrequency, IdleTimeout, error);
            }
            else
            {
                return Sunny86.Sunny_RedisDial(Context, host, pass, db, PoolSize, MinIdleCons, DialTimeout, ReadTimeout, WriteTimeout, PoolTimeout, IdleCheckFrequency, IdleTimeout, error);
            }
        }

        //// 释放 Redis 对象
        public static void RemoveRedis(System.Int32 Context)
        {
            if (Is64BitProcess)
            {
                Sunny64.Sunny_RemoveRedis(Context);
            }
            else
            {
                Sunny86.Sunny_RemoveRedis(Context);
            }
        }

        //// 创建 Redis 对象
        public static System.Int32 CreateRedis()
        {
            if (Is64BitProcess)
            {
                return (int)Sunny64.Sunny_CreateRedis();
            }
            else
            {
                return Sunny86.Sunny_CreateRedis();
            }
        }


        ////获取 UDP消息 返回数据指针
        public static IntPtr GetUdpData(System.Int32 MessageId)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetUdpData(MessageId);
            }
            else
            {
                return Sunny86.Sunny_GetUdpData(MessageId);
            }
        }

        ////修改设置 UDP消息 返回数据指针
        public static bool SetUdpData(System.Int32 MessageId, IntPtr val, System.Int32 valLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_SetUdpData(MessageId, val, valLen);
            }
            else
            {
                return Sunny86.Sunny_SetUdpData(MessageId, val, valLen);
            }
        }
        ////加指定的UDP连接 模拟客户端向服务器端主动发送数据
        public static bool UdpSendToServer(System.Int32 MessageId, IntPtr val, System.Int32 valLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_UdpSendToServer(MessageId, val, valLen);
            }
            else
            {
                return Sunny86.Sunny_UdpSendToServer(MessageId, val, valLen);
            }
        }
        ////指定的UDP连接 模拟服务器端向客户端主动发送数据
        public static bool UdpSendToClient(System.Int32 MessageId, IntPtr val, System.Int32 valLen)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_UdpSendToClient(MessageId, val, valLen);
            }
            else
            {
                return Sunny86.Sunny_UdpSendToClient(MessageId, val, valLen);
            }
        }
        ////释放指针
        public static bool Free(IntPtr Ptr)
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_Free(Ptr);
            }
            else
            {
                return Sunny86.Sunny_Free(Ptr);
            }
        }

        /// <summary> 
        /// 获取SunnyNet DLL 版本
        /// </summary>
        /// <returns></returns>
        public static IntPtr GetSunnyVersion()
        {
            if (Is64BitProcess)
            {
                return Sunny64.Sunny_GetSunnyVersion();
            }
            else
            {
                return Sunny86.Sunny_GetSunnyVersion();
            }
        }
    }
}
