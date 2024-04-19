using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HuluwaToken.Common;
using HuluwaToken.Entity;
using HuluwaToken.Model;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sunny.UI;
using SunnyTest;

namespace HuluwaToken
{
    public partial class MainForm : UIForm
    {
        SunnyNet sunnyNet = new SunnyNet();
        private static readonly string _defaultCaCrt = @"-----BEGIN CERTIFICATE-----
MIIDPTCCAiUCFDYMWl9W7NzNc4UnalNYatFR7614MA0GCSqGSIb3DQEBCwUAMFsx
CzAJBgNVBAYTAkFVMRMwEQYDVQQIDApTb21lLVN0YXRlMSEwHwYDVQQKDBhJbnRl
cm5ldCBXaWRnaXRzIFB0eSBMdGQxFDASBgNVBAMMC0h1bHV3YVRva2VuMB4XDTI0
MDQxOTA1NDUyMFoXDTM0MDQxNzA1NDUyMFowWzELMAkGA1UEBhMCQVUxEzARBgNV
BAgMClNvbWUtU3RhdGUxITAfBgNVBAoMGEludGVybmV0IFdpZGdpdHMgUHR5IEx0
ZDEUMBIGA1UEAwwLSHVsdXdhVG9rZW4wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAw
ggEKAoIBAQDWXLJIppqoUpvnFQ5J52KGxtzPloSsfZwTgd0+5udjTkfQtgXDjgZo
WyZdDz/JU5Tsr6J+BspbxK3sPyyYf2kVnSsFkGN2ZXXHMEBJWwZ9jUzqvibf0VFr
/NSfPPhBKVx391ST94dnq/NwEhwbYK6r+nYePVCjoJXl58u5xKUGKoh6ZPwrLlnc
v6701ncgtg5rmxDvr70NzmgWxTegPjSnu9yKyrCzceh3bCIqZeO7rooZM7H2VhX8
KNdCs9/ofsKHj3clG4Sr4UG81cAbux9imkHtqj66oTXzMIIJsDvOyE4BWUOaji5r
jXOkySbGPnVGrwVnmgW2FP1mxI/tecBTAgMBAAEwDQYJKoZIhvcNAQELBQADggEB
AJcDUTo/1QRjNYYJ+4GxKURN/HR92iOv2GuU3BEdAIn9UvGmzjlMYitMobpMMzOv
/x2CepYcmNX1FoeqiU2u1vXy6TZlw3e9nIZ6epkLWSWvZE2S3PSc53QZ9rSS/nby
02T9SJ8jd3tcoRmHf74ANNyFLazS/m75o60Jw+xz20ZmRyxgDrkltIteStWy+Zky
nCrk1EIHlFuP1ZwXauF0Cean2qSEjIuPFGbZVvCZdl1TDxfPD4DLzSl3/OC4ZBc0
vIH1CYxiHvNtLpChZTTqIEb7X8nskBG1NXYqAO1yOVYmSGoj9if15bun38QekC/L
ltjSK94Ba21MxFlQK9JYKO8=
-----END CERTIFICATE-----
";
        private static readonly string _defaultCaKey = @"-----BEGIN PRIVATE KEY-----
MIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDWXLJIppqoUpvn
FQ5J52KGxtzPloSsfZwTgd0+5udjTkfQtgXDjgZoWyZdDz/JU5Tsr6J+BspbxK3s
PyyYf2kVnSsFkGN2ZXXHMEBJWwZ9jUzqvibf0VFr/NSfPPhBKVx391ST94dnq/Nw
EhwbYK6r+nYePVCjoJXl58u5xKUGKoh6ZPwrLlncv6701ncgtg5rmxDvr70NzmgW
xTegPjSnu9yKyrCzceh3bCIqZeO7rooZM7H2VhX8KNdCs9/ofsKHj3clG4Sr4UG8
1cAbux9imkHtqj66oTXzMIIJsDvOyE4BWUOaji5rjXOkySbGPnVGrwVnmgW2FP1m
xI/tecBTAgMBAAECggEAU5ae8MSCr1tTLtdflIL1QQ//n7UWdDqg51xu/S3GEcu/
JkwsUDasGfpdKdGd8nA0tNzCFLmqJAG8PlDeH3Mjc4mvcoJ8vnjO5gbTMqebjs7Q
LQNMHl+9i8nx0UxRk/tAcwlPgkl2E/+RtGRjcGuRgT9v2tfW/49JlHaAUyayoQWy
/soc/F+oW1C5/eeSpW5Dh8vpi2AcCz1hJBr+1R3dFohLipNUUDq5zBv+DARxMiWH
UudCNMlJj2ycqhQbx2Na6B9+zdrloCEjtUzgjAz0zexb00aHHDSO2DHaTL7Es6j5
6TayAhqgD6mxHkibts8Ou7gzyFiDoHrz+8I9dKpFtQKBgQDfa1dqxGmZyi5Ysiwa
5MLfuv69SUW/0WUwwl5qLl1j98A8PKO73qFftpEgbiDuk2viRfZ633lRmw2XvEyc
xlAU1QJ+U3ozZV+FAqBP1aXo6w0CzjRvwN6tnqp+Ds5FfCbyM1IwmjgeQUKzVegb
+FNbMipucYE+1LM3Jhh6ZPQhRQKBgQD1nzuHtbB2dG/gLxDVOXYlOlNbQ/JBwvh9
ytYJV8QNmreVCXgVYJZQDnKNu9LeAEnkuMCT0zcAIEWizPkq04jG9OMP9KEEZDnN
xcm7nY4MnEYhZl6zEJU34LcYjgcbd9K71bcF2be8fKM6KQGHWMCB5djyQSjHq/0C
dxWlPTGYtwKBgQCw2uG6DHyjVp5Va8TqDQgN3pJj+CqUawc1D8d5OfaHecjcZgwe
XV9Uysoa59J9yIjv9v3jyh7Y8GpUIKRsvbcKpotwwFfNc4OnYKrSR4cr11TXUa/E
fuJGgYDohIPYES0rMGDxREMEABjyqSAxc+NYH1/jSUpMGEc9cpSR3nQ6GQKBgQCJ
i63uhVRYQUQVKsYmYZNDrbHYPeh/4wr8hoXtnXRwmd+MWk0gy4HhOvXzYObo4wh+
SOeu4GzAaVIVpOszjFnf8GrnGHrC1s136fbaVZSigzDSq10EsZiePfzKh157h1I/
VaK0aAN4TeOqQiRVAuJq26ftoYeQqUN6Ce3ZJreLaQKBgF5MpwsZMoDIgCXjJgKT
JMZdhwnjPDRwDokkIQrtv1kKiblv5tcH09pp4gu3RWwmD9cip/p3YsLtYZtAMjU9
6GsBIX2L0btTxvIdUujrZZmkVsRQr4r/xNRVsM6ADX/r58sLGzt6KpqqZWrVjTDJ
hBhdn1W18gV+Zw1v5tYpPzIr
-----END PRIVATE KEY-----
";
        private UserEntity _currentUser;
        private QinglongHelper _qinglongHelper;
        public MainForm()
        {
            InitializeComponent();
            QlConfig.Current.Load();
            CertConfig.Current.Load();
            Proxy.LoadProxy();
            uiSwitchQl.Active = QlConfig.Current.IsOpen;
            uiTxbUrl.Text = QlConfig.Current.Url;
            uiTxbAppId.Text = QlConfig.Current.AppId;
            uiTxbAppSecret.Text = QlConfig.Current.AppSecret;

            uiSwitchCert.Active = CertConfig.Current.IsOpen;
            uiTxbCaCrt.Text = CertConfig.Current.CaCrt;
            uiTxbCaKey.Text = CertConfig.Current.CaKey;

            InitCertificate();
            _ = InitQinglongHelper();


            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "小程序名称",
                DataPropertyName = "Name",
                ValueType = typeof(string),
                Width = 150,
            });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "更新时间",
                DataPropertyName = "UpdateTime",
                Width = 170,
            });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Token值",
                DataPropertyName = "Token",
                Width = 300,
            });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "AppId",
                DataPropertyName = "AppId",
                Visible = false,
            });
            uiDataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Key",
                DataPropertyName = "Key",
                Visible = false,
            });

            var user = SqlSugarHelper.DB.Queryable<UserEntity>().InSingle(UserConfig.Current.CurrentUserName);
            if (user != null)
            {
                _currentUser = user;
            }
            else
            {
                SelectUser();
            }

            BindUserData();
        }

        #region 事件绑定
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void uiBtnInstall_Click(object sender, EventArgs e)
        {
            try
            {
                var ca = sunnyNet.导出证书();
                Install(ca);
                ShowSuccessTip("证书安装成功");
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }
        private void uiBtnCert_Click(object sender, EventArgs e)
        {
            CertConfig.Current.IsOpen = uiSwitchCert.Active;
            CertConfig.Current.CaCrt = uiTxbCaCrt.Text;
            CertConfig.Current.CaKey = uiTxbCaKey.Text;
            if (InitCertificate(true))
            {
                ShowSuccessTip("应用成功");
                CertConfig.Current.Save();
            }
        }

        private void uiBtnStart_Click(object sender, EventArgs e)
        {
            if (uiBtnStart.Text == "停止")
            {
                sunnyNet.停止代理();
                ShowSuccessTip("停止成功");
                uiBtnStart.Text = "启动";
                Proxy.ReSetProxy();
                return;
            }
            sunnyNet.绑定端口(2023);
            sunnyNet.绑定回调地址(HttpCallback);
            var ret = sunnyNet.启动();
            if (ret)
            {
                Proxy.SetProxy("127.0.0.1:2023", true);
                ShowSuccessTip("启动成功");
                uiBtnStart.Text = "停止";
            }
            else
            {
                var err = sunnyNet.取错误();
                ShowErrorDialog(err);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sunnyNet.停止代理();
            Proxy.ReSetProxy();
        }

        private void uiTxbCaCrt_ButtonClick(object sender, EventArgs e)
        {
            StringEditForm frm = new StringEditForm();
            frm.Render();
            frm.Text = "请填写证书公钥内容";
            frm.Value = ((UITextBox)sender).Text;
            frm.ShowDialog();
            if (frm.IsOK)
            {
                var value = frm.Value;
                ((UITextBox)sender).Text = value;
            }
        }

        private void uiTxbCaKey_ButtonClick(object sender, EventArgs e)
        {
            StringEditForm frm = new StringEditForm();
            frm.Render();
            frm.Text = "请填写证书Key内容";
            frm.Value = ((UITextBox)sender).Text;
            frm.ShowDialog();
            if (frm.IsOK)
            {
                var value = frm.Value;
                ((UITextBox)sender).Text = value;
            }
        }

        private void uiSwitchCert_ValueChanged(object sender, bool value)
        {
            uiTxbCaCrt.Enabled = value;
            uiTxbCaKey.Enabled = value;
        }

        private void uiSwitchQl_ValueChanged(object sender, bool value)
        {
            uiTxbUrl.Enabled = value;
            uiTxbAppId.Enabled = value;
            uiTxbAppSecret.Enabled = value;
        }

        private void uiTxbUser_ButtonClick(object sender, EventArgs e)
        {
            SelectUser();
            BindUserData();
        }

        private void uiBtnTips_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.CurrentRow == null)
            {
                ShowErrorTip("请先选择一条数据");
                return;
            }
            var selectRow = (TokenItem)uiDataGridView1.CurrentRow.DataBoundItem;
            if (selectRow == null)
            {
                ShowErrorTip("请先选择一条数据");
                return;
            }
            ShowInfoDialog(selectRow.ToString());
        }

        private async void uiBtnQl_Click(object sender, EventArgs e)
        {
            QlConfig.Current.IsOpen = uiSwitchQl.Active;
            QlConfig.Current.Url = uiTxbUrl.Text;
            QlConfig.Current.AppId = uiTxbAppId.Text;
            QlConfig.Current.AppSecret = uiTxbAppSecret.Text;
            if (await InitQinglongHelper(true))
            {
                ShowSuccessTip("应用成功");
                QlConfig.Current.Save();
            }
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 选择用户
        /// </summary>
        private void SelectUser()
        {
            SelectUserForm selectUserForm = new SelectUserForm();
            selectUserForm.ShowDialog();
            _currentUser = selectUserForm.GetSelectUser();

            UserConfig.Current.CurrentUserName = _currentUser.Name;
            UserConfig.Current.Save();
        }

        /// <summary>
        /// 处理用户数据
        /// </summary>
        private void BindUserData()
        {
            uiDataGridView1.DataSource = _currentUser.TokenItems;
            uiDataGridView1.Invalidate();

            uiTxbUser.Text = _currentUser.Name;
            SqlSugarHelper.DB.Updateable(_currentUser).ExecuteCommand();
        }


        /// <summary>
        /// 初始化证书
        /// </summary>
        /// <param name="showErr">是否提示错误</param>
        /// <returns>返回是否初始化成功</returns>
        private bool InitCertificate(bool showErr = false)
        {
            if (CertConfig.Current.IsOpen)
            {
                return LoadCertificate(CertConfig.Current.CaCrt, CertConfig.Current.CaKey, showErr);
            }
            else
            {
                return LoadCertificate(_defaultCaCrt, _defaultCaKey, showErr);
            }
        }

        /// <summary>
        /// 加载证书
        /// </summary>
        /// <param name="crt"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private bool LoadCertificate(string crt, string key, bool showErr = false)
        {
            crt = crt.Trim();
            key = key.Trim();
            try
            {
                if (!crt.StartsWith("-----BEGIN CERTIFICATE-----") || !crt.EndsWith("-----END CERTIFICATE-----"))
                {
                    if (showErr)
                        UIMessageBox.ShowError("证书内容不合法,请确保是:\r\n内容开头：-----BEGIN CERTIFICATE-----\r\n内容结尾：-----END CERTIFICATE-----");
                    return false;
                }
                if (!key.StartsWith("-----BEGIN PRIVATE KEY-----") || !key.EndsWith("-----END PRIVATE KEY-----"))
                {
                    if (showErr)
                        UIMessageBox.ShowError("证书Key不合法，请确保是:\r\n内容开头：-----BEGIN PRIVATE KEY-----\r\n内容结尾：-----END PRIVATE KEY-----");
                    return false;
                }
                X509Certificate2 x509Certificate2 = new X509Certificate2(Encoding.Default.GetBytes(crt));

                CertificateManager certificateManager = new CertificateManager();
                certificateManager._载入X509Certificate("", crt, key);
                var ret = sunnyNet.设置自定义CA证书(certificateManager);
                if (ret)
                {
                    var cn = certificateManager.获取CommonName();
                    var isInstall = CheckInstall(crt);
                    uiLabCertState.Text = cn + (isInstall ? "（已安装）" : "（未安装）");
                    return true;
                }
                else
                {
                    if (showErr)
                        UIMessageBox.ShowError(sunnyNet.取错误());
                    return false;
                }

            }
            catch (Exception ex)
            {
                if (showErr)
                    UIMessageBox.ShowError(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 检查证书是否安装
        /// </summary>
        /// <param name="cn"></param>
        /// <returns></returns>
        private bool CheckInstall(string cer)
        {
            X509Certificate2 x509Certificate2 = new X509Certificate2(Encoding.Default.GetBytes(cer));
            using (var store = new X509Store(StoreName.Root, StoreLocation.CurrentUser))
            {
                store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                X509Certificate2Collection collection = store.Certificates;
                X509Certificate2Collection fcollection = collection.Find(X509FindType.FindByThumbprint, x509Certificate2.Thumbprint, false);
                return fcollection != null && fcollection.Count > 0;
            }
        }

        /// <summary>
        /// 安装ca证书
        /// </summary>
        /// <exception cref="Exception">不能安装证书</exception>
        private void Install(string crt)
        {
            try
            {
                using (var store = new X509Store(StoreName.Root, StoreLocation.LocalMachine))
                {
                    store.Open(OpenFlags.ReadWrite);

                    var caCert = new X509Certificate2(Encoding.Default.GetBytes(crt));
                    foreach (var item in store.Certificates.Find(X509FindType.FindByThumbprint, caCert.Thumbprint, false))
                    {
                        if (item.Thumbprint != caCert.Thumbprint)
                        {
                            store.Remove(item);
                        }
                    }
                    if (store.Certificates.Find(X509FindType.FindByThumbprint, caCert.Thumbprint, true).Count == 0)
                    {
                        store.Add(caCert);
                    }
                    store.Close();
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText("ca.crt", crt);
                Process.Start("ca.crt");
                throw new Exception($"证书安装失败:{ex.Message}\r\n请手动安装根目录的【ca.crt】CA证书文件\r\n安装到“当前用户”->“将所有的证书都放入下列存储”->“受信任的根证书颁发机构”");
            }
        }

        /// <summary>
        /// 初始化青龙帮助类
        /// </summary>
        /// <param name="showErr"></param>
        /// <returns></returns>
        private async Task<bool> InitQinglongHelper(bool showErr = false)
        {
            if (QlConfig.Current.IsOpen)
            {
                try
                {
                    var helper = new QinglongHelper(QlConfig.Current.Url,
                         QlConfig.Current.AppId,
                         QlConfig.Current.AppSecret);
                    await helper.Login();
                    _qinglongHelper = helper;
                    uiLabQlState.Text = "青龙连接成功";
                    return true;
                }
                catch (Exception ex)
                {
                    if (showErr)
                        ShowErrorDialog(ex.Message);

                    return false;
                }
            }
            else
            {
                uiLabQlState.Text = "";
                _qinglongHelper = null;
                return true;
            }
        }

        private async Task Result(string appId, string token)
        {
            if (string.IsNullOrEmpty(appId) || string.IsNullOrEmpty(token)) return;
            var item = _currentUser.TokenItems.FirstOrDefault(m => m.AppId == appId);
            if (item == null) return;

            item.Token = token;
            item.UpdateTime = DateTime.Now;
            _currentUser.UpdateTime = DateTime.Now;
            try
            {
                if (_qinglongHelper != null)
                    await _qinglongHelper.AddOrUpdate(item.Key, token);
            }
            catch (Exception ex)
            {
                ShowErrorDialog($"上传青龙失败: {ex.Message}");
            }

            ShowSuccessTip($"{item.Name}获取Token成功");
            BindUserData();
        }

        /// <summary>
        /// 缓存请求参数
        /// </summary>
        private Dictionary<int, string> _dicParas = new Dictionary<int, string>();

        /// <summary>
        /// HTTP/HTTPS 回调
        /// </summary>
        /// <param name="唯一ID"></param>
        /// <param name="messageId"></param>
        /// <param name="消息类型">Const.Net_Http_</param>
        /// <param name="method"></param>
        /// <param name="url"></param>
        /// <param name="err"></param>
        /// <param name="pid">进程PID 若等于0 表示通过代理远程请求 无进程PID</param>
        private bool HttpCallback(int sunnyContext, int 唯一ID, int messageId, int 消息类型, string method, string url, string err, int pid)
        {
            if (!url.Contains("/front-manager/api/login/wxMiniLogin")) return true;

            Console.Write(url);

            Request Request = SunnyTest.Sunny.MessageIdToSunny(messageId);

            if (消息类型 == Const.Net_Http_Request)
            {
                try
                {
                    var paraStr = Request.request.取POST数据_字符串_UTF8();
                    var json = JsonConvert.DeserializeObject<WxLoginInput>(paraStr);
                    if (json != null && !string.IsNullOrEmpty(json.appId))
                    {
                        _dicParas[唯一ID] = json.appId;
                    }
                }
                catch (Exception ex) { }
            }
            else if (消息类型 == Const.Net_Http_Response)
            {
                try
                {

                    if (_dicParas.TryGetValue(唯一ID, out string appId) && !string.IsNullOrEmpty(appId))
                    {
                        var str = Request.response.取响应内容_UTF8();
                        var ret = JsonConvert.DeserializeObject<WxRet<WxLoginOutput>>(str);
                        var token = ret?.data?.token;
                        if (!string.IsNullOrEmpty(token))
                        {
                            _ = Result(appId, token);
                        }
                    }
                }
                catch (Exception ex) { }
            }

            return true;
        }

        #endregion
    }
}
