using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    public class Api
    {
        public string GetApi(string URL) {

            var client = new HttpClient();

            var url = new Uri(URL);

            var result =  client.GetAsync(url).Result;

            var jsonArray = result.Content.ReadAsStringAsync().Result;

            return jsonArray;



        }
    }
}
