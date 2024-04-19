using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace HuluwaToken.Common
{
    public class Proxy
    {
        private static bool _proxyEnable = false;
        private static string _proxyServer = "";
        private static bool _isChanged = false;

        // DllImport：动态端口
        [DllImport(@"wininet",
        SetLastError = true,
        CharSet = CharSet.Auto,
        EntryPoint = "InternetSetOption",
        CallingConvention = CallingConvention.StdCall)]
        // InternetSetOption：互联网设置选项
        public static extern bool InternetSetOption
        (
            int hInternet,
            int dmOption,
            IntPtr lpBuffer,
            int dwBufferLength
         );
        /// <summary>
        /// 设置代理
        /// </summary>
        public static void SetProxy(string proxyServer, bool proxyEnable)
        {
            //打开注册表CurrentUser
            var regKey = Registry.CurrentUser;
            //计算机\HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings
            const string subKeyPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            var optionKey = regKey.OpenSubKey(subKeyPath, true);
            //更改健值，设置代理
            if (optionKey != null)
            {
                // 赋值
                optionKey.SetValue("ProxyEnable", (proxyEnable ? "1" : "0"), RegistryValueKind.DWord);
                optionKey.SetValue("ProxyServer", proxyServer);
            }
            //激活代理设置    
            InternetSetOption(0, 39, IntPtr.Zero, 0);
            InternetSetOption(0, 37, IntPtr.Zero, 0);
            _isChanged = true;
        }

        /// <summary>
        /// 重置代理为初始状态
        /// </summary>
        public static void ReSetProxy()
        {
            if (_isChanged)
                SetProxy(_proxyServer, _proxyEnable);
            _isChanged = false;
        }

        /// <summary>
        /// 获取系统代理并缓存
        /// </summary>
        public static void LoadProxy()
        {
            //打开注册表CurrentUser
            var regKey = Registry.CurrentUser;

            const string subKeyPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            var optionKey = regKey.OpenSubKey(subKeyPath, true);
            //更改健值，设置代理
            if (optionKey != null)
            {
                // 获取是否使用代理服务器
                string proxyEnable = optionKey.GetValue("ProxyEnable").ToString();
                _proxyEnable = proxyEnable == "1";

                // 获取地址跟端口
                string addressAndPort = optionKey.GetValue("ProxyServer").ToString();
                _proxyServer = addressAndPort;
            }
        }
    }
}
