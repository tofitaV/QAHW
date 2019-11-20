using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JsonHW
{
    class Program
    {
        static string uri = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=1000&api_key=DEMO_KEY";
        static void  Main(string[] args)
        {
            string JsonMassive = "";

            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                JsonMassive = reader.ReadToEnd();
            }
            JsonClass json = WorkWithInfo.ParseJson(JsonMassive);
            Console.WriteLine(json.photos.First().camera.full_name);
            foreach (var item in json.photos)
            {
                Console.WriteLine("Id = " + item.id);
              
                Console.WriteLine("sol = " + item.sol);
            }
        }
    }
}
