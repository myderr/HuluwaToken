using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HuluwaToken.Extensions;
using HuluwaToken.Model;

namespace HuluwaToken.Common
{
    public class QinglongHelper
    {
        private string _prefix = "__HuluwaToken__";
        private string _url;
        private string _appId;
        private string _appSecret;
        private string _userName;
        private QlLogin _qlLogin;
        private List<QlEnv> _qlEnvList;
        public QinglongHelper(string url, string appId, string appSecret, string userName)
        {
            _url = url;
            _appId = appId;
            _appSecret = appSecret;
            _userName = userName;
        }

        private HttpClient GetHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_url);

            if (_qlLogin != null)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_qlLogin.token_type, _qlLogin.token);
            }


            return client;
        }

        private string GetRemarks()
        {
            return $"{_prefix}{_userName}";
        }

        private async Task GetEnvList()
        {
            var ret = await GetHttpClient().GetAsync<QlRet<List<QlEnv>>>($"/open/envs?searchValue={GetRemarks()}");
            if (!string.IsNullOrEmpty(ret.message))
            {
                throw new Exception(ret.message);
            }
            var envList = ret.data;
            if (envList == null)
                envList = new List<QlEnv>();
            _qlEnvList = envList.Where(m => m.status == QlStatu.启用).ToList();
        }

        public async Task Login()
        {
            var ret = await GetHttpClient().GetAsync<QlRet<QlLogin>>($"/open/auth/token?client_id={_appId}&client_secret={_appSecret}");
            if (!string.IsNullOrEmpty(ret.message))
            {
                throw new Exception(ret.message);
            }
            var loginDarta = ret.data;
            if (loginDarta == null)
            {
                throw new Exception("登录出错");
            }
            _qlLogin = loginDarta;
            await GetEnvList();
        }

        public async Task AddOrUpdate(string name, string value)
        {
            var env = _qlEnvList.FirstOrDefault(m => m.name == name);
            if (env == null)
            {
                var envAdd = new QlEnvAdd();
                envAdd.name = name;
                envAdd.value = value;
                envAdd.remarks = GetRemarks();

                var ret = await GetHttpClient().PostAsync<QlRet<List<QlEnv>>>("/open/envs", new List<QlEnvAdd>() { envAdd });

                if (!string.IsNullOrEmpty(ret.message))
                {
                    throw new Exception(ret.message);
                }
            }
            else
            {
                var envUpdate = new QlEnvUpdate();
                envUpdate.id = env.id;
                envUpdate.name = name;
                envUpdate.value = value;
                envUpdate.remarks = GetRemarks();

                var ret = await GetHttpClient().PutAsync<QlRet<QlEnv>>("/open/envs", envUpdate);

                if (!string.IsNullOrEmpty(ret.message))
                {
                    throw new Exception(ret.message);
                }
            }

            await GetEnvList();
        }
    }
}
