using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuluwaToken.Entity;
using Newtonsoft.Json;
using SqlSugar;
using Sunny.UI;

namespace HuluwaToken.Common
{
    public class DbConfigBase<TConfig> where TConfig : DbConfigBase<TConfig>, new()
    {
        protected static TConfig current;
        public static TConfig Current
        {
            get
            {
                if (current != null)
                {
                    return current;
                }
                current = CreateNew();
                current.Load();
                return current;
            }
            set
            {
                current = value;
            }
        }
        private static TConfig CreateNew()
        {
            TConfig val = new TConfig();
            val.SetDefault();
            return val;
        }


        public bool Load()
        {
            var entity = SqlSugarHelper.DB.Queryable<DbConfigEntity>().InSingle(typeof(TConfig).Name);
            if (entity == null)
            {
                current.Save();
            }
            else
            {
                current = JsonConvert.DeserializeObject<TConfig>(entity.Value);
            }

            return true;
        }
        public bool Save()
        {
            SqlSugarHelper.DB.Storageable(new DbConfigEntity()
            {
                Key = typeof(TConfig).Name,
                Value = JsonConvert.SerializeObject(current)
            }).ExecuteCommand();
            return true;
        }
        public virtual void SetDefault()
        {
        }
    }
}
