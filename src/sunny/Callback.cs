using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sunny.UI;

namespace SunnyTest
{
    /// <summary>
    ///  回调函数接口
    /// </summary>
    static class Callback
    {
        /// <summary>
        /// Ws客户端回调委托
        /// </summary>
        /// <param name="Context"></param>
        /// <param name="消息类型">1=接收消息 2=接收时连接被断开 3=发送时连接被断开</param>
        /// <param name="数据指针">消息类型=2、3时 这里是错误信息</param>
        /// <param name="指针长度"></param>
        /// <param name="数据类型">Const.WSClient_ (当消息类型=1时有效)</param>
        public static bool WsClientCallback(int Context, int 消息类型, IntPtr 数据指针, int 指针长度, int 数据类型)
        {
            string str = Tool.PtrToString(数据指针);

            Console.WriteLine("WS 收到数据：" + str);
            //这里返回值是什么不重要，但得有
            return true;
        }




        /// <summary>
        /// TCP客户端回调委托
        /// </summary>
        /// <param name="Context"></param>
        /// <param name="消息类型">1=接收消息 2=接收时连接被断开 3=发送时连接被断开 4=即将连接</param>
        /// <param name="数据指针">消息类型=2、3时 这里是错误信息</param>
        /// <param name="指针长度"></param>
        public static bool TcpClientCallback(int Context, int 消息类型, IntPtr 数据指针, int 指针长度)
        {
            string str = Tool.PtrToString(数据指针);

            Console.WriteLine("tcp 收到数据：" + str);


            //这里返回值是什么不重要，但得有
            return true;
        }


        static Dictionary<int, string> appids = new Dictionary<int, string>();

        /// <summary>
        /// HTTP/HTTPS 回调
        /// </summary>
        /// <param name="唯一ID"></param>
        /// <param name="MessageId"></param>
        /// <param name="消息类型">Const.Net_Http_</param>
        /// <param name="Method"></param>
        /// <param name="Url"></param>
        /// <param name="err"></param>
        /// <param name="pid">进程PID 若等于0 表示通过代理远程请求 无进程PID</param>
        public static bool HTTP回调(int SunnyContext, int 唯一ID, int MessageId, int 消息类型, string Method, string Url, string err, int pid)
        {
            if (!Url.Contains("wxMiniLogin")) return true;
            //if (!Url.Contains("baidu.com")) return true;

            Request Request = Sunny.MessageIdToSunny(MessageId);

            if (消息类型 == Const.Net_Http_Request)
            {
                var paraStr = Request.request.取POST数据_字符串_UTF8();
                appids[唯一ID] = paraStr;
                Console.WriteLine(paraStr);
            }
            else if (消息类型 == Const.Net_Http_Response)
            {
                var paraStr = appids[唯一ID];
                var str = Request.response.取响应内容_UTF8();
                //str = str.Replace("百度", "千寻");
                //Request.response.修改响应内容_字符串_UTF8(str);
                Console.WriteLine(str);

            }
            else if (消息类型 == Const.Net_Http_Request_Fail)
            {

            }

            return true;
        }



        /// <summary>
        /// WebSocket 回调
        /// </summary>
        /// <param name="唯一ID"></param>
        /// <param name="MessageId"></param>
        /// <param name="消息类型">[ Const.Net_Http_Wss_ ] or [ Const.Net_Http_Ws_ ]</param>
        /// <param name="Method"></param>
        /// <param name="Url"></param>
        /// <param name="err"></param>
        /// <param name="pid">进程PID 若等于0 表示通过代理远程请求 无进程PID</param>
        /// <param name="WsMsgType">Const.WSClient_</param>
        public static bool WebSocket回调(int SunnyContext, int 唯一ID, int MessageId, int 消息类型, string Method, string Url, int pid, int WsMsgType)
        {
            //这里虽然的WS的回调 但是也可以使用 Request.request 得到请求信息
            Request Request = Sunny.MessageIdToSunny(MessageId);

            //ws的操作
            //SunnyPublic.ws_取Body(MessageId);
            //SunnyPublic.ws_修改Body(MessageId,data);
            //SunnyPublic.ws_发送Body(    发送方向=  0 或 1     ,唯一ID , data);
            //SunnyPublic.ws_取Body长度(MessageId);  
            //SunnyPublic.ws_断开指定连接(唯一ID);

            if (消息类型 == Const.Net_Http_Websocket_Connection)
            {
                //ws或wss 连接成功

                Console.WriteLine("WS 连接成功 :" + Url);
            }
            else if (消息类型 == Const.Net_Http_Websocket_Disconnect)
            {
                //ws或wss 断开连接
                Console.WriteLine("WS 断开连接 :" + Url);
            }
            else if (消息类型 == Const.Net_Http_Websocket_send)
            {

                //ws或wss 发送数据
                Console.WriteLine("WS 发送数据 :" + Tool.BytesToStr(SunnyPublic.ws_取Body(MessageId)));
            }
            else if (消息类型 == Const.Net_Http_Websocket_received)
            {
                //ws或wss 收到数据
                Console.WriteLine("WS 收到数据 :" + Url);
            }

            //这里返回值是什么不重要，但得有
            return true;
        }


        /// <summary>
        /// TCP回调
        /// </summary>
        /// <param name="来源地址"></param>
        /// <param name="远程地址"></param>
        /// <param name="消息类型">Const.Net_TCP_</param>
        /// <param name="MessageId"></param>
        /// <param name="数据指针">会话类型  0、3 时 无效</param>
        /// <param name="数据长度"></param>
        /// <param name="唯一ID">会话类型  0、3 时 无效</param>
        /// <param name="pid">进程PID 若等于0 表示通过代理远程请求 无进程PID</param>
        /// <returns></returns>
        public static bool TCP回调(int SunnyContext, string 来源地址, string 远程地址, int 消息类型, int MessageId, IntPtr 数据指针, int 数据长度, int 唯一ID, int pid)
        {

            if (消息类型 == Const.Net_TCP_Enter)
            {
                //连接成功
                Console.WriteLine("连接成功 ：" + 来源地址 + " -> " + 远程地址);
            }
            else if (消息类型 == Const.Net_TCP_Received)
            {
                //收到数据
                Console.WriteLine("收到数据 ：" + 来源地址 + " -> " + 远程地址);
            }
            else if (消息类型 == Const.Net_TCP_Send)
            {
                //发送数据
                Console.WriteLine("发送数据 ：" + 来源地址 + " -> " + 远程地址);
            }
            else if (消息类型 == Const.Net_TCP_Disconnect)
            {
                //断开连接
                Console.WriteLine("断开连接 ：" + 来源地址 + " -> " + 远程地址);
            }
            else if (消息类型 == Const.Net_TCP_Waiting)
            {
                /*即将连接
                 * 
                 * 再这里可以修改远程地址 
                 * 
                 * 如：(需要带上端口号)
                    SunnyPublic.Tcp_连接重定向(MessageId, "8.8.8.8:80");
                 */
                Console.WriteLine("即将连接 ：" + 来源地址 + " -> " + 远程地址);
            }




            //这里返回值是什么不重要，但得有
            return true;
        }

        /// <summary>
        /// UDP回调
        /// </summary>
        /// <param name="来源地址"></param>
        /// <param name="远程地址"></param>
        /// <param name="消息类型">Const.Net_TCP_</param>
        /// <param name="MessageId"></param>
        /// <param name="唯一ID">会话类型  0、3 时 无效</param>
        /// <param name="pid">进程PID 若等于0 表示通过代理远程请求 无进程PID</param>
        /// <returns></returns>
        public static bool UDP回调(int SunnyContext, string 来源地址, string 远程地址, int 事件类型, int MessageId, int 唯一ID, int pid)
        {

            if (事件类型 == Const.Net_UDP_Send)
            {
                byte[] Body = SunnyPublic.UDP_取Body(MessageId);

                //发送数据
                Console.WriteLine("UDP 客户端 发送数据 ：唯一ID={0}  长度={1}", 唯一ID, Body.Length);
                //其他命令
                //SunnyPublic.UDP_向客户端发送消息();
                //SunnyPublic.UDP_向服务器发送消息();
            }
            else if (事件类型 == Const.Net_UDP_Received)
            {
                byte[] Body = SunnyPublic.UDP_取Body(MessageId);

                //收到数据
                Console.WriteLine("UDP 客户端 收到数据 ：唯一ID={0}  长度={1}", 唯一ID, Body.Length);

                //其他命令
                //SunnyPublic.UDP_向客户端发送消息();
                //SunnyPublic.UDP_向服务器发送消息();
            }
            else if (事件类型 == Const.Net_UDP_Close)
            {
                //UDP会话结束
                Console.WriteLine("UDP断开连接 ：{0} ", 唯一ID);
            }


            //这里返回值是什么不重要，但得有
            return true;
        }
    }
}
