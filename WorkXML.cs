using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HWLinqXml
{
   public class WorkXML
    {
        XDocument xdoc = XDocument.Load("D:\\Users\\Vladik\\source\\repos\\HWLinqXml\\HWLinqXml\\XMLFile.xml");
        public List<User> XmlSelary(int selery)
        {
            List<User> list = new List<User>();
            List<XElement> items = xdoc.Root.Elements("Employee").ToList();
            items = items.Where(e => int.Parse(e.Element("Salery").Value) >= selery).ToList();
                       
            foreach(var item in items)
            {
                User info = new User()
                {
                    id = item.Element("Id").Value,
                    firstName = item.Element("FirstName").Value,
                    lastName = item.Element("LastName").Value,
                    selery = item.Element("Salery").Value
                };
                list.Add(info);
            }
            return list;
        }
    }
}
