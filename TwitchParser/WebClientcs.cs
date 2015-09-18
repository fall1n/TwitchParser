using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace TwitchParser
{
    public class WebApi
    {
        public string Url { get; private set; }

        public WebApi SetUp(string url)
        {
            Url = url;
            return this;
        }

        public async Task<string> Request()
        {
            HttpClient request = new HttpClient();
            string result = await request.GetStringAsync(Url);
            return result;
        }
    }
}
