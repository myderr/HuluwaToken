using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuluwaToken.Model
{
    public class WxRet<T>
    {
        public string traceId { get; set; }
        public long serverTimeStamp { get; set; }
        public string code { get; set; }
        public T data { get; set; }
        public bool success { get; set; }
    }
    public class WxLoginInput
    {
        public string appId { get; set; }
        public string code { get; set; }
    }

    public class WxLoginOutput
    {
        public bool isNeedRegister { get; set; }
        public bool isNew { get; set; }
        public string token { get; set; }
    }

}
