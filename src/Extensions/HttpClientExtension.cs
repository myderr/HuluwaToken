using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HuluwaToken.Extensions
{
    public static class HttpClientExtension
    {
        public static T Get<T>(this HttpClient client, string requestUri)
        {
            return client.GetAsync<T>(requestUri).GetAwaiter().GetResult();
        }
        public static async Task<T> GetAsync<T>(this HttpClient client, string requestUri)
        {
            var text = await client.GetStringAsync(requestUri);
            if (typeof(T) == typeof(string))
            {
                return (T)(object)text;
            }
            if (string.IsNullOrWhiteSpace(text)) return default;
            var result = JsonConvert.DeserializeObject<T>(text);
            return result;
        }

        public static T Post<T>(this HttpClient client, string requestUri, object body = default)
        {
            return client.PostAsync<T>(requestUri, body).GetAwaiter().GetResult();
        }

        public static Task<T> PostAsync<T>(this HttpClient client, string requestUri, object body = default)
        {
            return client.SendAsync<T>(HttpMethod.Post, requestUri, body);
        }

        public static T Put<T>(this HttpClient client, string requestUri, object body = default)
        {
            return client.PutAsync<T>(requestUri, body).GetAwaiter().GetResult();
        }

        public static Task<T> PutAsync<T>(this HttpClient client, string requestUri, object body = default)
        {
            return client.SendAsync<T>(HttpMethod.Put, requestUri, body);
        }

        public static async Task<T> SendAsync<T>(this HttpClient client, HttpMethod method, string requestUri, object body = default)
        {
            var request = new HttpRequestMessage(method, requestUri);
            if (body != null)
            {
                HttpContent httpContent;
                if (body.GetType() == typeof(string))
                {
                    httpContent = new StringContent((string)body);
                }
                else
                {
                    httpContent = new StringContent(JsonConvert.SerializeObject(body));
                }
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                request.Content = httpContent;
            }

            var response = await client.SendAsync(request);
            if (response == null || response.Content == null) return default;

            // 获取 charset 编码
            var encoding = GetCharsetEncoding(response);

            // 读取内容字节流
            var content = await response.Content.ReadAsByteArrayAsync();

            // 通过指定编码解码
            var text = encoding.GetString(content);

            if (typeof(T) == typeof(string))
            {
                return (T)(object)text;
            }
            if (string.IsNullOrWhiteSpace(text)) return default;
            var result = JsonConvert.DeserializeObject<T>(text);
            return result;
        }

        /// <summary>
        /// 解析响应报文 charset 编码
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private static Encoding GetCharsetEncoding(HttpResponseMessage response)
        {
            if (response == null) return Encoding.UTF8;

            // 获取 charset
            string charset;

            // 获取响应头的编码格式
            var withContentType = response.Content.Headers.TryGetValues("Content-Type", out var contentTypes);
            if (withContentType)
            {
                charset = contentTypes.First()
                                      .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Where(u => u.Contains("charset"))
                                      .FirstOrDefault() ?? "charset=UTF-8";
            }
            else charset = "charset=UTF-8";

            var encoding = charset.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault() ?? "UTF-8";

            // 标准化 charset 名称
            var encodingName = encoding.Equals("utf8", StringComparison.OrdinalIgnoreCase) ? "UTF-8" :
                               encoding.Equals("utf16", StringComparison.OrdinalIgnoreCase) ? "UTF-16" :
                               encoding.Equals("utf32", StringComparison.OrdinalIgnoreCase) ? "UTF-32" :
                               encoding;

            // 获取 Encoding
            try
            {
                return Encoding.GetEncoding(encodingName);
            }
            catch (ArgumentException)
            {
                // 如果无法识别 encodingName，则返回默认的 UTF-8 编码
                return Encoding.UTF8;
            }
        }
    }
}
