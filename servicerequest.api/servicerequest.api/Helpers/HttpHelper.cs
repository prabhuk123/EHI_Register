using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using servicerequest.api.Common;

namespace servicerequest.api.Helpers
{
    public class HttpHelper
    {
        public async Task<TResult> PostAsync<TPost, TResult>(string baseUrl,string root, TPost data)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, baseUrl+root);
            var content = new StringContent(data.ToJson(), Encoding.UTF8, "application/json");
            request.Content = content;
            using (var client = new HttpClient())
            {
                var header = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(AppSettingsroots.EhiAuthenticationUserName+":"+AppSettingsroots.EhiAuthenticationPassword)));///username:password for auth
                client.DefaultRequestHeaders.Authorization = header;

                var response = await client.SendAsync(request);
                //await response.EnsureSuccessStatusCodeAsync();
                var stringResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResult>(stringResult);
            }
        }
        //public class SuccessResult<T> : Result<T>
        //{
        //    public SuccessResult(T value) : base(true, new List<string>())
        //    {
        //        Value = value;
        //    }
        //}
    }
}
