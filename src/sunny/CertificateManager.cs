using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace SunnyTest
{
    /// <summary>
    /// 证书管理器，请参考易语言用法
    /// </summary>
    public class CertificateManager
    {
        private int Context = 0;

        public CertificateManager()
        {
            Context = Sunny.CreateCertificate();
            跳过主机验证();
        }

        ~CertificateManager(){
            //自动销毁
            Sunny.RemoveCertificate(Context);
        }
      
        public void 重新创建()
        {
            Sunny.RemoveCertificate(Context);
            Context = Sunny.CreateCertificate();
            跳过主机验证();
        }
        public void 跳过主机验证(bool Skip = true)
        {
            Sunny.SetInsecureSkipVerify(Context, Skip);
        }
        public bool _载入P12Certificate(string P12证书路径, string P12证书密码)
        {
            IntPtr A = Tool.StringToIntptr(P12证书路径);
            IntPtr B = Tool.StringToIntptr(P12证书密码);
            bool b = Sunny.LoadP12Certificate(Context, A, B);
            Tool.PtrFree(A);
            Tool.PtrFree(B);
            return b; 
        }
        /// <summary>
        /// 载入X509KeyPair 从一对文件读取和解析一个公钥/私钥对。文件必须包含PEM编码的数据。证书文件可以在叶证书之后包含中间证书，形成证书链。 默认 跳过主机验证
        /// </summary>
        /// <param name="cert文件路径"></param>
        /// <param name="key文件路径"></param>
        /// <returns>成功返回true</returns>
        public bool _载入X509KeyPair(string cert文件路径, string key文件路径)
        {
            IntPtr A = Tool.StringToIntptr(cert文件路径);
            IntPtr B = Tool.StringToIntptr(key文件路径);
            bool b = Sunny.LoadX509KeyPair(Context, A, B);
            Tool.PtrFree(A);
            Tool.PtrFree(B);
            return b;

        }
        public bool _载入X509Certificate(string Host, string cer文件内容, string key文件内容)
        {
            IntPtr A = Tool.StringToIntptr(Host);
            IntPtr B = Tool.StringToIntptr(cer文件内容);
            IntPtr C = Tool.StringToIntptr(key文件内容);
            bool b = Sunny.LoadX509Certificate(Context, A, B, C);
            Tool.PtrFree(A);
            Tool.PtrFree(B);
            Tool.PtrFree(C);
            return b;

        }
        /// <summary>
        /// 设置ServerName 请先载入证书 设置的证书上的主机名
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public bool 设置ServerName(string Name)
        {
            IntPtr A = Tool.StringToIntptr(Name);
            bool b = Sunny.SetServerName(Context, A);
            Tool.PtrFree(A);
            return b;

        }
        /// <summary>
        /// 获取ServerName 请先载入证书 返回的证书上的主机名
        /// </summary>
        /// <returns></returns>
        public string 获取ServerName()
        {
            IntPtr b = Sunny.GetServerName(Context);
            if (b.ToInt64() < 1)
            {
                return "";
            }
            string ss = Tool.PtrToString(b);
            Sunny.Free(b);//释放Sunny接收的指针
            return ss;

        }

        public int 获取证书Context()
        {
            return Context;
        }

        /// <summary>
        /// 添加客户端信任证书_文件
        /// </summary>
        /// <param name="文件路径"></param>
        /// <returns></returns>
        public bool 添加客户端信任证书_文件(string 文件路径)
        {
            IntPtr A = Tool.StringToIntptr(文件路径);
            bool b = Sunny.AddCertPoolPath(Context, A);
            Tool.PtrFree(A);
            return b;
        }


        /// <summary>
        /// 添加客户端信任证书_文本
        /// </summary>
        /// <param name="文件路径"></param>
        /// <returns></returns>
        public bool 添加客户端信任证书_文本(string 信任的证书文件内容)
        {
            IntPtr A = Tool.StringToIntptr(信任的证书文件内容);
            bool b = Sunny.AddCertPoolText(Context, A);
            Tool.PtrFree(A);
            return b;
        }
        /// <summary>
        /// 设置客户端身份验证模式 0-4 请使用 Const.SSL_ClientAuth_
        /// </summary>
        /// <param name="文件路径"></param>
        /// <returns></returns>
        public bool 设置客户端身份验证模式(int 模式 = 0)
        {
            bool b = Sunny.AddClientAuth(Context, 模式);
            return b;
        }
        /// <summary>
        /// 创建证书
        /// </summary>
        /// <param name="证书域名">例如：www.baidu.com</param>
        /// <param name="证书所属的国家">默认CN</param>
        /// <param name="证书存放的公司名称">默认Sunny</param>
        /// <param name="证书所属的部门名称">默认Sunny</param>
        /// <param name="证书签发机构所在省">默认BeiJing</param>
        /// <param name="证书签发机构所在市">默认BeiJing</param>
        /// <param name="到期时间">单位、天。从现在起的多少天到期。默认3650天</param>
        /// <returns></returns>
        public bool 创建证书(string 证书域名, string 证书所属的国家 = "CN", string 证书存放的公司名称 = "Sunny", string 证书所属的部门名称 = "Sunny", string 证书签发机构所在省 = "BeiJing", string 证书签发机构所在市 = "BeiJing", int 到期时间 = 3650)
        {
            IntPtr A = Tool.StringToIntptr(证书域名);
            IntPtr B = Tool.StringToIntptr(证书所属的国家);
            IntPtr C = Tool.StringToIntptr(证书存放的公司名称);
            IntPtr D = Tool.StringToIntptr(证书所属的部门名称);
            IntPtr E = Tool.StringToIntptr(证书签发机构所在省);
            IntPtr F = Tool.StringToIntptr(证书签发机构所在市);
            bool b = Sunny.CreateCA(Context, A, B, C, D, E, F, 2048, 到期时间);
            Tool.PtrFree(A);
            Tool.PtrFree(B);
            Tool.PtrFree(C);
            Tool.PtrFree(D);
            Tool.PtrFree(E);
            Tool.PtrFree(F);
            return b;
        }
        /// <summary>
        /// 导出公钥
        /// </summary>
        /// <returns></returns>
        public string 导出公钥()
        {
            IntPtr ptr = Sunny.ExportPub(Context);
            string a = replace_enter(Tool.PtrToString(ptr));
            Sunny.Free(ptr);//释放Sunny接收的指针
            return a; 
        }
        /// <summary>
        /// 导出私钥
        /// </summary>
        /// <returns></returns>
        public string 导出私钥()
        {
            IntPtr ptr = Sunny.ExportKEY(Context);
            string a = replace_enter(Tool.PtrToString(ptr));
            Sunny.Free(ptr);//释放Sunny接收的指针
            return a; 
        }
        /// <summary>
        /// 导出私钥
        /// </summary>
        /// <returns></returns>
        public string 导出CA证书()
        {
            IntPtr ptr = Sunny.ExportCA(Context);
            string a= replace_enter(Tool.PtrToString(ptr));
            Sunny.Free(ptr);//释放Sunny接收的指针
            return a;

        }
        /// <summary>
        /// 导出P12文件
        /// </summary>
        /// <param name="保存路径"></param>
        /// <param name="P12密码"></param>
        /// <returns></returns>
        public bool 导出P12文件(string 保存路径 ,string P12密码)
        {
            IntPtr A = Tool.StringToIntptr(保存路径);
            IntPtr B = Tool.StringToIntptr(P12密码);
            bool b = Sunny.ExportP12(Context,A,B);
            Tool.PtrFree(A);
            Tool.PtrFree(B);
            return b; 
        }
        private string replace_enter(string s) {
           // return s.Replace("\n", "");
            return s;
        }

        /// <summary>
        /// 请先载入证书 返回的证书上的“颁发给”
        /// </summary>
        public string 获取CommonName()
        {
            IntPtr ptr = Sunny.GetCommonName(Context);
            string ret = Tool.PtrToString(ptr);
            Sunny.Free(ptr);//释放Sunny接收的指针
            return ret;
        }

    }
}
