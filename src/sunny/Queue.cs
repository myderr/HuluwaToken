using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace SunnyTest
{
    /// <summary>
    /// 队列类，请参考易语言用法
    /// </summary>
    public class Queue
    {
        private IntPtr ConText ;
 
        public void 置唯一标识(string s)
        {
            if (ConText.ToInt64() != 0) {
                Tool.PtrFree(ConText);
            }
            ConText = Tool.StringToIntptr(s);
        }
        public bool 是否为空()
        {
            return Sunny.QueueIsEmpty(ConText);
        }
        public void 清空()
        {
            销毁();
            创建队列( "");
        }
        /// <summary>
        /// 需手动销毁
        /// </summary>
        public void 销毁()
        {
            Sunny.QueueRelease(ConText);
            if (ConText.ToInt64() != 0)
            {
                Tool.PtrFree(ConText); 
            }
        }
        public void 创建队列(string id)
        {
            if (id != "")
            {
                if (ConText.ToInt64() != 0)
                {
                    Tool.PtrFree(ConText);
                }
                ConText = Tool.StringToIntptr(id);
            }
        
            Sunny.CreateQueue(ConText);
        }
        public int 取队列长度()
        {
            return Sunny.QueueLength(ConText);
        }

        public void 压入_字节集(byte[] bin)
        {
            IntPtr a = Tool.BytesToIntptr(bin);
            Sunny.QueuePush(ConText, a, bin.Length);
            Tool.PtrFree(a);
        }
        public void 压入(string s)
        {
            IntPtr p = Tool.StringToIntptr(s);
            Sunny.QueuePush(ConText, p, s.Length);
            Tool.PtrFree(p);
        }
        public string 弹出()
        {
            byte[] bin = 弹出_字节集();
            return System.Text.Encoding.Default.GetString(bin);
        }
        public  byte[] 弹出_字节集()
        { 
            IntPtr ptr = Sunny.QueuePull(ConText);
            if (ptr.ToInt64() == 0)
            { 
                return new byte[0];
            }
            byte[] sa= Tool.PtrAutoToBytes(ptr);
            Sunny.Free(ptr);//释放Sunny接收的指针
            return sa;
        }
    }
}
