using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sever
{
    public class Json
    {
        public Json()
        {

        }
        void Parsing(String json_st)
        {
            string json = json_st;
            JArray array = JArray.Parse(json);
            string type;
            string id;
            string pw;
            try
            {
                foreach (JObject JObject in array)
                {
                    type = JObject["type"].ToString();
                    if (type == "login")
                    {
                        id = JObject["id"].ToString();
                        pw = JObject["pw"].ToString();
                    }
                }
            }
            catch {}
        }

    }
}
