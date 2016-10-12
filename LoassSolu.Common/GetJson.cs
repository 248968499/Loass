using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks; 
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace LoassSolu.Common
{
    public class GetJson
    {
        public static HttpResponseMessage toJson(Object obj)
        {
            var iso = new IsoDateTimeConverter();
            iso.DateTimeFormat = "yyyy-MM-dd hh:mm:ss";
            String str;
            if (obj is String || obj is Char)
            {
                str = obj.ToString();
            }
            else
            {
                str = JsonConvert.SerializeObject(obj, iso);
            }
            HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }
    }
}
