using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunnyTest.sunny
{
    class Redis
    {
        private int Context;
        private int db = 0;
        private IntPtr err=Tool.mallocIntptr(256);
        public Redis()
        {
            Context = Sunny.CreateRedis(); 
        }

        ~Redis()
        {
            //自动销毁
            Sunny.RemoveRedis(Context);
            Tool.PtrFree(err);
        }
        public string 取错误()
        {
            return Tool.PtrToString(err);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="主机名">127.0.0.1:6739</param>
        /// <param name="密码"></param>
        /// <param name="数据库">默认0号数据库</param>
        /// <param name="连接池数量">默认15</param>
        /// <param name="最小连接数">默认10</param>
        /// <param name="连接超时时间">单位秒 默认5</param>
        /// <param name="读取超时">单位秒 默认5</param>
        /// <param name="写入超时">单位秒 默认5</param>
        /// <param name="PoolTimeout">[当所有连接都在繁忙状态时,客户端等待可用连接的最大等待时间] 单位秒 默认5</param>
        /// <param name="闲置连接检查周期">单位秒 默认60</param>
        /// <param name="闲置超时">单位秒 默认5</param> 
        /// <returns></returns>
        public bool 连接(string 主机名, string 密码, System.Int32 数据库=0, System.Int32 连接池数量=15, System.Int32 最小连接数=10, System.Int32 连接超时时间=5, System.Int32 读取超时=5, System.Int32 写入超时=5, System.Int32 PoolTimeout=5, System.Int32 闲置连接检查周期=60, System.Int32 闲置超时=5)
        {
            db = 数据库;
            IntPtr _主机名 = Tool.StringToIntptr(主机名);
            IntPtr _密码 = Tool.StringToIntptr(密码); 
            bool ret = Sunny.RedisDial(Context, _主机名 , _密码, db, 连接池数量, 最小连接数, 连接超时时间, 读取超时, 写入超时, PoolTimeout, 闲置连接检查周期, 闲置超时,err);
            Tool.PtrFree(_主机名);
            Tool.PtrFree(_密码); 
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public string 取文本值(string 键名)
        {
            IntPtr _键名 = Tool.StringToIntptr(键名);
            IntPtr p = Sunny.RedisGetStr(Context, _键名);
            string ret =Tool.PtrToString(p);
            Sunny.Free(p);//释放Sunny接收的指针
            Tool.PtrFree(_键名);
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] 取字节集(string 键名)
        {
            IntPtr _键名 = Tool.StringToIntptr(键名);
            IntPtr p = Sunny.RedisGetBytes(Context, _键名);
            byte[] ret = Tool.PtrAutoToBytes(p);
            Sunny.Free(p);//释放Sunny接收的指针
            Tool.PtrFree(_键名);
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Key是否存在(string key)
        {
            IntPtr _key = Tool.StringToIntptr(key);
            bool ret = Sunny.RedisExists(Context, _key);
            Tool.PtrFree(_key);
            return ret;
        }

        /// <summary>
        /// 如果键名存在返回假
        /// </summary>
        /// <param name="键名"></param>
        /// <param name="值"></param>
        /// <param name="过期时间">单位秒，0表示永不过期</param>
        /// <returns></returns>
        public bool 设置NX(string 键名, string 值, System.Int32 过期时间=0)
        {
            if (键名 == "") {
                return false;
            }
            IntPtr _键名 = Tool.StringToIntptr(键名);
            IntPtr _值 = Tool.StringToIntptr(值);
            bool ret = Sunny.RedisSetNx(Context, _键名, _值, 过期时间);
            Tool.PtrFree(_键名);
            Tool.PtrFree(_值);
            return ret;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="键名"></param>
        /// <param name="值"></param>
        /// <param name="过期时间">单位秒，0表示永不过期</param>
        /// <returns></returns>
        public bool 设置(string 键名, string 值, System.Int32 过期时间=0)
        {
            if (键名 == "")
            {
                return false;
            }
            IntPtr _键名 = Tool.StringToIntptr(键名);
            IntPtr _值 = Tool.StringToIntptr(值);
            bool ret = Sunny.RedisSet(Context, _键名, _值, 过期时间);
            Tool.PtrFree(_键名);
            Tool.PtrFree(_值);
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool 设置字节集(string 键名, byte[] 值, System.Int32 过期时间)
        {
            if (键名 == "")
            {
                return false;
            }
            IntPtr _键名 = Tool.StringToIntptr(键名);
            IntPtr _值 = Tool.BytesToIntptr(值);
            bool ret = Sunny.RedisSetBytes(Context, _键名, _值, 值.Length, 过期时间);
            Tool.PtrFree(_键名);
            Tool.PtrFree(_值);
            return ret;
        }

        /// <summary>
        /// 自定义 执行和查询命令 返回操作结果可能是值 也可能是JSON文本
        /// </summary>
        public string Do(string 执行语句)
        {
            IntPtr _执行语句 = Tool.StringToIntptr(执行语句);
            IntPtr p = Sunny.RedisDo(Context, _执行语句, err);
            string ret = Tool.PtrToString(p);
            Sunny.Free(p);//释放Sunny接收的指针
            Tool.PtrFree(_执行语句); 
            return ret;
        }

        /// <summary>
        /// 返回键名数组
        /// </summary>
        public string[] 取指定条件键名(string 指定条件)
        {
            string[] arr=new string[0];
              
            IntPtr _指定条件 = Tool.StringToIntptr(指定条件);
            IntPtr ret = Sunny.RedisGetKeys(Context, _指定条件);
            Tool.PtrFree(_指定条件);
            if (ret.ToInt64() == 0)
            {
                return arr;
            }
            byte[] bs = Tool.PtrAutoToBytes(ret);
            Sunny.Free(ret);//释放Sunny接收的指针
            for (int i = 0; i< bs.Length; i++) {
                if (bs[i] == 0) {
                    bs[i] = 9;
                }
            }
            string ss = System.Text.Encoding.Default.GetString(bs);
            arr=ss.Split('\t');
            return arr;
        }

        /// <summary>
        /// 
        /// </summary>
        public long 取整数值(string 键名)
        {
            IntPtr _键名 = Tool.StringToIntptr(键名);
            long ret = Sunny.RedisGetInt(Context, _键名);
            Tool.PtrFree(_键名);
            return ret;
        }

        /// <summary>
        /// 一般情况下，不用调用，类销毁时 内部 自动调用
        /// </summary>
        public void 关闭()
        {
            Sunny.RedisClose(Context);
        }

        /// <summary>
        /// 用于清空整个 redis 服务器的数据(删除所有数据库的所有 key )。
        /// </summary>
        public void 清空redis服务器()
        {
            Sunny.RedisFlushAll(Context);
        }

        /// <summary>
        /// 用于清空当前数据库中的所有 key。
        /// </summary>
        public void 清空当前数据库()
        {
            Sunny.RedisFlushDB(Context);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool 删除(string 键名)
        {
            IntPtr _键名 = Tool.StringToIntptr(键名);
            bool ret = Sunny.RedisDelete(Context, _键名);
            Tool.PtrFree(_键名);
            return ret;
        }

        /// <summary>
        /// 返回键名数组
        /// </summary>
        public string[] 取所有键名()
        { 
            return 取指定条件键名("*");
        }

    }
}
