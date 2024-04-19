using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace HuluwaToken.Entity
{
    [SugarTable]
    public class DbConfigEntity
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string Key { get; set; }

        [SugarColumn(IsArray = true)]
        public string Value { get; set; }
    }
}
