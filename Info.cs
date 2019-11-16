using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLinqXml
{
     class Info
    {
         static void Main(string[] args)
        {
            WorkXML workXML = new WorkXML();
            List<User> list = workXML.XmlSelary(100000);
            foreach (var item in list)
            {
                Console.WriteLine(item.firstName);
            }

        }
    }
}
