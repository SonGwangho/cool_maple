using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using cool_maple.Model;

namespace cool_maple.API
{
    internal static class MapleAPI
    {
        private static readonly string APIKEY = ConfigurationManager.AppSettings.Get("APIKEY");
        private static readonly string BaseUrl = "https://open.api.nexon.com/maplestory/";
        private static AuthenticationHeaderValue Headers = new AuthenticationHeaderValue("x-nxopen-api-key", APIKEY);
        private static string? ocid;

        private static async Task<HttpContent> SendApi(string endpoint, object? body)
        {
            string url = BaseUrl + endpoint;

            using var client = new HttpClient();
            HttpResponseMessage response;

            client.DefaultRequestHeaders.Add("x-nxopen-api-key", APIKEY);
            client.DefaultRequestHeaders.Add("accept", "application/json");

            if (body is null)
            {
                response = await client.GetAsync(url);
            }
            else
            {
                response = await client.GetAsync($"{url}?{ToQueryString(body)}");
            }

            if (response.IsSuccessStatusCode)
            {
                return response.Content;
            }
            else
            {
                throw new Exception("API 호출 실패");
            }
        }

        private static string ToQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return String.Join("&", properties.ToArray());
        }

        public static async Task SetCharacter(string name)
        {
            var response = await SendApi("v1/id", new
            {
                character_name = name
            });

            string responseString = await response.ReadAsStringAsync();
            var obj = JObject.Parse(responseString);
            ocid = obj.GetValue("ocid").ToString();
        }

        public static async Task<CharacterBasicModel> GetBasic()
        {
            var response = await SendApi("v1/character/basic", new
            {
                ocid = ocid
            });

            string responseString = await response.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CharacterBasicModel>(responseString);
        }
    }
}
