using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuluwaToken.Model
{
    public class QlRet<T>
    {
        public int code { get; set; }
        public string message { get; set; }
        public T data { get; set; }
    }

    public class QlEnvBase
    {
        public string name { get; set; }
        public string value { get; set; }
        public string remarks { get; set; }
    }

    public class QlEnvAdd: QlEnvBase
    {

    }

    public class QlEnvUpdate : QlEnvBase
    {
        public int id { get; set; }
    }

    public class QlEnv: QlEnvUpdate
    {
        //public string timestamp { get; set; }
        public QlStatu status { get; set; }
        //public long position { get; set; }
        //public DateTime createdAt { get; set; }
        //public DateTime updatedAt { get; set; }
    }


    public class QlLogin
    {
        public string token { get; set; }
        public string token_type { get; set; }
        public int expiration { get; set; }
    }


    public enum QlStatu
    {
        启用,
        禁用
    }

}
