using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuluwaToken.Model
{
    public class TokenItem
    {
        public string Name { get; set; }
        public string AppId { get; set; }
        public string Token { get; set; }
        /// <summary>
        /// 脚本需要的环境变量key
        /// </summary>
        public string Key {  get; set; }
        public DateTime UpdateTime { get; set; }
        public override string ToString()
        {
            return $"名称：{Name}\r\n最后更新时间：{UpdateTime:yyyy-MM-dd HH:mm:ss}\r\nToken：{Token}";
        }
    }
}
