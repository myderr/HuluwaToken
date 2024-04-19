using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuluwaToken.Model;
using SqlSugar;

namespace HuluwaToken.Entity
{
    [SugarTable]
    public class UserEntity
    {
        public UserEntity()
        {

        }

        [SugarColumn(IsPrimaryKey = true)]
        public string Name { get; set; }
        public DateTime UpdateTime { get; set; }
        [SugarColumn(IsJson = true)]
        public List<TokenItem> TokenItems { get; set; }

        public static UserEntity Create(string name)
        {
            var newCreate = Create();
            newCreate.Name = name;
            return newCreate;
        }
        public static UserEntity Create()
        {
            var dataList = new List<TokenItem>
            {
                new TokenItem()
                {
                    Name = "新联惠购",
                    AppId = "wxded2e7e6d60ac09d",
                    Key="XLTH_COOKIE",
                    UpdateTime = DateTime.Now,
                },
                new TokenItem()
                {
                    Name = "贵旅优品",
                    AppId = "wx61549642d715f361",
                    Key="GLYP_COOKIE",
                    UpdateTime = DateTime.Now,
                },
                new TokenItem()
                {
                    Name = "空港乐购",
                    AppId = "wx613ba8ea6a002aa8",
                    Key="KGLG_COOKIE",
                    UpdateTime = DateTime.Now,
                },
                new TokenItem()
                {
                    Name = "航旅黔购",
                    AppId = "wx936aa5357931e226",
                    Key="HLQG_COOKIE",
                    UpdateTime = DateTime.Now,
                },
                new TokenItem()
                {
                    Name = "遵航出山",
                    AppId = "wx624149b74233c99a",
                    Key="ZHCS_COOKIE",
                    UpdateTime = DateTime.Now,
                },
                new TokenItem()
                {
                    Name = "贵盐黔品",
                    AppId = "wx5508e31ffe9366b8",
                    Key="GYQP_COOKIE",
                    UpdateTime = DateTime.Now,
                },
                new TokenItem()
                {
                    Name = "乐旅商城",
                    AppId = "wx821fb4d8604ed4d6",
                    Key="LLSC_COOKIE",
                    UpdateTime = DateTime.Now,
                },
                new TokenItem()
                {
                    Name = "驿路黔寻",
                    AppId = "wxee0ce83ab4b26f9c",
                    Key="YLQX_COOKIE",
                    UpdateTime = DateTime.Now,
                }
            };
            var newCreate = new UserEntity();
            newCreate.UpdateTime = DateTime.Now;
            newCreate.TokenItems = dataList;
            return newCreate;
        }
    }
}
