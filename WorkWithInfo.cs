using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace JsonHW
{
    class WorkWithInfo
    {
        public string line = "";
        
        public static JsonClass ParseJson(string jsonMassive)
        {
       
            JsonClass json = JsonConvert.DeserializeObject<JsonClass>(jsonMassive);

            return json;
        }

        
    }
}
