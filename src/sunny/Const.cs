using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace SunnyTest
{
    /// <summary>
    /// 常量类
    /// </summary>
    public class Const
    {
        /// <summary>
        /// 表示在握手过程中不应该请求客户端证书，并且如果发送了任何证书，它们将不会被验证。
        /// </summary>
        public const int SSL_ClientAuth_NoClientCert = 0;
        /// <summary>
        /// 表示应该在握手过程中请求客户端证书，但不要求客户端发送任何证书。
        /// </summary>
        public const int SSL_ClientAuth_RequestClientCert = 1;
        /// <summary>
        /// 表示在握手过程中应该请求客户端证书，并且客户端至少需要发送一个证书，但该证书不需要有效。
        /// </summary>
        public const int SSL_ClientAuth_RequireAnyClientCert = 2;
        /// <summary>
        /// 表示应该在握手过程中请求客户端证书，但不要求客户端发送证书。如果客户端发送了一个证书，它就需要是有效的。
        /// </summary>
        public const int SSL_ClientAuth_VerifyClientCertIfGiven = 2;
        /// <summary>
        /// 表示握手时需要请求客户端证书，客户端至少需要发送一个有效的证书。
        /// </summary>
        public const int SSL_ClientAuth_RequireAndVerifyClientCert = 2;

   

        //WS 客户端的一些常量
        public const int WSClient_TextMessage = 1;
        public const int WSClient_BinaryMessage = 2;
        public const int WSClient_CloseMessage = 8;
        public const int WSClient_PingMessage = 9;
        public const int WSClient_PongMessage = 10;
        public const int WSClient_invalid = -1; 

         
        /// <summary>
        /// 收到请求(客户端发起请求)
        /// </summary>
        public const int Net_Http_Request = 1;

        /// <summary>
        /// 请求返回(服务端返回)
        /// </summary>
        public const int Net_Http_Response = 2;

        /// <summary>
        /// Http请求失败
        /// </summary>
        public const int Net_Http_Request_Fail = 3;


        /// <summary>
        /// Websocket 连接成功
        /// </summary>
        public const int Net_Http_Websocket_Connection = 1;

        /// <summary>
        /// Websocket 发送数据
        /// </summary>
        public const int Net_Http_Websocket_send = 2;

        /// <summary>
        /// Websocket 收到数据
        /// </summary>
        public const int Net_Http_Websocket_received = 3;

        /// <summary>
        /// Websocket 断开连接
        /// </summary>
        public const int Net_Http_Websocket_Disconnect = 4;


        /// <summary>
        /// TCP进入连接成功
        /// </summary>
        public const int Net_TCP_Enter = 0;
        /// <summary>
        /// TCP发送数据
        /// </summary>
        public const int Net_TCP_Send = 1;
        /// <summary>
        /// TCP收到数据
        /// </summary>
        public const int Net_TCP_Received = 2;
        /// <summary>
        /// TCP断开连接
        /// </summary>
        public const int Net_TCP_Disconnect = 3;
        /// <summary>
        /// TCP即将连接
        /// </summary>
        public const int Net_TCP_Waiting = 4;



        /// <summary>
        /// UDP会话断开
        /// </summary>
        public const int Net_UDP_Close = 1;
        /// <summary>
        /// UDP客户端发送数据
        /// </summary>
        public const int Net_UDP_Send = 2;
        /// <summary>
        /// UDP客户端接收数据
        /// </summary>
        public const int Net_UDP_Received = 3; 
    }
}
