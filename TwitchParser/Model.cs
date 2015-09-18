using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchParser
{
    public class Json
    {
        public List<Model> streams { get; set; }
    }

    public class Model
    {
        public string _id { get; set; }
        public Channel channel { get; set; }
    }

    public class Channel
    {
        public string display_name { get; set; } 
    }
}
