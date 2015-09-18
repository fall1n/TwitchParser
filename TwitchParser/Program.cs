using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TwitchParser
{
    class Program
    {
        static void Main(string[] args)
        {
            DoStuff();
        }

        private static DataTable DoStuff()
        {
            var task = new WebApi().SetUp("https://api.twitch.tv/kraken/streams?game=Smite").Request();

            var json = task.Result;

            var list = JsonConvert.DeserializeObject<Json>(json);

            DataTable dt = new DataTable();
            dt.Columns.Add("display_name", typeof(string));

            foreach (var stream in list.streams)
            {
                if (stream.channel != null)
                {
                    dt.Rows.Add(stream.channel.display_name);
                    Console.WriteLine(stream._id + " - " + stream.channel.display_name);
                }
            }
           
            Console.ReadLine();
            return dt;
        }
    }
}
