using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuluwaToken.Common;
using SqlSugar;

namespace HuluwaToken.Model
{
    public class UserConfig : DbConfigBase<UserConfig>
    {
        public string CurrentUserName { get; set; }
    }
    public class QlConfig : DbConfigBase<QlConfig>
    {
        /// <summary>
        /// 是否自动上传
        /// </summary>
        public bool IsOpen { get; set; }
        public string Url { get; set; }
        public string AppId { get; set; }
        public string AppSecret { get; set; }
    }

    public class CertConfig : DbConfigBase<CertConfig>
    {
        /// <summary>
        /// 是否自定义证书
        /// </summary>
        public bool IsOpen { get; set; }

        public string CaCrt { get; set; }
        public string CaKey { get; set; }

        public override void SetDefault()
        {
            base.SetDefault();
        }
    }
}
