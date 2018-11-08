using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    public class Recipient
    {
        public List<object> tags { get; set; }
        public string name { get; set; }
        public int id { get; set; }
    }

    public class RootObject
    {
        public List<Recipient> recipients { get; set; }
    }

    public class RecipientJson
    {
        public RootObject GetJson()
        {
            string json = null;

            using (StreamReader r = new StreamReader(@"../../Content/data.json"))
            {
                 json = r.ReadToEnd();
            }
            var rootObject = JsonConvert.DeserializeObject<RootObject>(json);

            return rootObject;
        }
    }
   
}
