using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Json
    {
        public static string id;
        public static string pw;
        public static void Pasing(object json_re)
        {
            string json = (string)json_re;
            JArray array = JArray.Parse(json);
            string type;
            try
            {
                foreach (JObject JObject in array)
                {
                    type = JObject["type"].ToString();
                    if (type == "login")
                    {
                        id = JObject["id"].ToString();
                        pw = JObject["pw"].ToString();
                        //디비비교_보내기(id,pw);
                    }
                }
            }
            catch {}
        }
        public static void unPasing(object Stream)
        {
            string str = (string)Stream;
            JArray jArray = new JArray();
            jArray.Add("1번 값");
            jArray.Add("2번 값");
            JObject jObject = new JObject();
            jObject["이름"]= jArray;
            string json = jObject.ToString();
            socket.보냄(str,json);
        }

    }
}
