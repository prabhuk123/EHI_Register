using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servicerequest.api.Common
{
    public static class JsonExtensions
    {
        public static string ToJson<T>(this T data)
        {
            return JsonConvert.SerializeObject(data);
        }

      
    }
}
