using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunnyTest
{
    /// <summary>
    /// Sunny存取键值表，在C#中可能不好用，但是还是写一遍
    /// </summary>
    class SunnyKeyValueTable
    {

        private int Context = 0;
        public SunnyKeyValueTable()
        {
            Context = Sunny.CreateKeys();
        }
         
        ~SunnyKeyValueTable()
        {
            //自动销毁
            Sunny.RemoveKeys(Context);
        }

        public void 重新创建()
        {
            Sunny.RemoveKeys(Context);
            Context = Sunny.CreateKeys();
        }

        public void 写文本(string 名, string 值)
        {
            byte[] 值1 = Tool.StrToBytes(值);
            IntPtr A = Tool.StringToIntptr(名);
            IntPtr B = Tool.BytesToIntptr(值1);
            Sunny.KeysWriteStr(Context, A, B, 值1.Length);
            Tool.PtrFree(A);
            Tool.PtrFree(B);
        }

        public void 写字节集(string 名, byte[] 值)
        {
            IntPtr A = Tool.StringToIntptr(名);
            IntPtr B = Tool.BytesToIntptr(值);
            Sunny.KeysWrite(Context, A, B, 值.Length);
            Tool.PtrFree(A);
            Tool.PtrFree(B);
        }


        public void 写双精度(string 名, Double 值)
        {
            IntPtr A = Tool.StringToIntptr(名);
            Sunny.KeysWriteFloat(Context, A, 值);
            Tool.PtrFree(A);
        }

        public void 写长整数(string 名, long 值)
        {
            IntPtr A = Tool.StringToIntptr(名);
            Sunny.KeysWriteLong(Context, A, 值);
            Tool.PtrFree(A);
        }
        public void 写整数(string 名, int 值)
        {
            IntPtr A = Tool.StringToIntptr(名);
            Sunny.KeysWriteInt(Context, A, 值);
            Tool.PtrFree(A);
        }
        public int 读整数(string 名)
        {
            IntPtr A = Tool.StringToIntptr(名);
            int r = Sunny.KeysReadInt(Context, A);
            Tool.PtrFree(A);
            return r;
        }
        public long 读长整数(string 名)
        {
            IntPtr A = Tool.StringToIntptr(名);
            long r = Sunny.KeysReadLong(Context, A);
            Tool.PtrFree(A);
            return r;
        }
        public Double 读双精度(string 名)
        {
            IntPtr A = Tool.StringToIntptr(名);
            Double r = Sunny.KeysReadFloat(Context, A);
            Tool.PtrFree(A);
            return r;
        }
        public string 读文本(string 名)
        {
            byte[] bs = 读字节集(名); 
            return Tool.BytesToStr(bs);
        }
        public byte[] 读字节集(string 名)
        {
            IntPtr A = Tool.StringToIntptr(名); 
            IntPtr r = Sunny.KeysRead(Context, A); 
            Tool.PtrFree(A);
            byte[] aaa = Tool.PtrAutoToBytes(r);
            Sunny.Free(r);//释放Sunny接收的指针
            return aaa;
 
        }
        public void 清空()
        {
            Sunny.KeysEmpty(Context);
        }
        public void 删除成员(string 名)
        {
            IntPtr A = Tool.StringToIntptr(名);
            Sunny.KeysDelete(Context, A);
            Tool.PtrFree(A);
        }
        public string 到Json()
        {
            IntPtr A = Sunny.KeysGetJson(Context);
            if (A.ToInt64() < 1)
            {
                return "";
            }
            string a = Tool.PtrToString(A);
            Sunny.Free(A);//释放Sunny接收的指针
            return a;


        }
        public int 取键值数()
        {
            return Sunny.KeysGetCount(Context);
        }
    }
}
