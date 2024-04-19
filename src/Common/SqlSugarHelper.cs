using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuluwaToken.Entity;
using HuluwaToken.Model;
using SqlSugar;

namespace HuluwaToken.Common
{
    internal class SqlSugarHelper
    {
        public static SqlSugarScope DB = new SqlSugarScope(new ConnectionConfig()
        {
            ConnectionString = "DataSource=./HuluwaToken.db",
            DbType = DbType.Sqlite,
            IsAutoCloseConnection = true,
            ConfigureExternalServices = new ConfigureExternalServices()
            {
                EntityService = (type, column) =>
                {
                    if (column.IsPrimarykey == false)
                    {
                        column.IsNullable = true;
                    }
                },
            }
        }, db =>
        {

        });

        public static void Init()
        {
            DB.CodeFirst.InitTables(typeof(DbConfigEntity), typeof(UserEntity));
        }
    }
}
