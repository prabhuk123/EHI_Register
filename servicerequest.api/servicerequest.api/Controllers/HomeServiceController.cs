using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using servicerequest.api.Interfaces;
using servicerequest.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using servicerequest.api.Common;
using servicerequest.api.Helpers;
using ServiceRequestModels.api.Models;
using System.Net.Http.Formatting;
using System.Globalization;

namespace servicerequest.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeServiceController : ControllerBase
    {
        private readonly IHomeService _homeService;
        private readonly HttpHelper _httpHelper;

        public HomeServiceController(IHomeService homeService )
        {
            _homeService = homeService;
           
        }
               
        [HttpPost]
        [Route("userinfo")]
        public async Task<Result> PostUserInfo([FromBody]UserInfo serviceRequest)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, AppSettingsroots.EhiAuthenticationBaseUrl+ RoutconstanUrl.AuthenticationUserInforoute);
            var content = new StringContent(serviceRequest.ToJson(), Encoding.UTF8, "application/json");
            request.Content = content;
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.Add("EhiDemoUsername", "2C9CE6438F8B");
                client.DefaultRequestHeaders.Add("EhiDemoPassword", "E71E71AD-C89A-4BBC-AFA4-0B4F2E8CAD34");

                var response = await client.SendAsync(request);
                //await response.EnsureSuccessStatusCodeAsync();
                var stringResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Result>(stringResult);
              
            }
                      
        }

        [HttpPost]
        [Route("userupload")]
        public async Task<Result> PostUpload(Upload serviceRequest)
        {

   
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("EhiDemoUsername", "2C9CE6438F8B");
                client.DefaultRequestHeaders.Add("EhiDemoPassword", "E71E71AD-C89A-4BBC-AFA4-0B4F2E8CAD34");
                using (var content =
                    new MultipartFormDataContent("Upload----" + DateTime.Now.ToString(CultureInfo.InvariantCulture)))
                {
                    ByteArrayContent bytecontent = new ByteArrayContent(serviceRequest.PdfData);
                    bytecontent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
                    bytecontent.Headers.ContentDisposition.Name = "\"Image1\"";
                    bytecontent.Headers.ContentDisposition.FileName = serviceRequest.FileName;
                    bytecontent.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                    content.Add(bytecontent);
                    
                    content.Add(new StringContent(serviceRequest.Email), "Email");
                    content.Add(new StringContent(serviceRequest.Id.ToString()), "Id");


                    using (
                       var message =
                           await client.PostAsync(AppSettingsroots.EhiAuthenticationBaseUrl + RoutconstanUrl.AuthenticationUploadRoute, content))
                    {
                        var input = await message.Content.ReadAsStringAsync();

                        return JsonConvert.DeserializeObject<Result>(input);
                    }
                }
            }


        }




    }
}