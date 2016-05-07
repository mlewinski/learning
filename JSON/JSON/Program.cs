using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            String JSONstring = File.ReadAllText("JSON.json");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Person p1 = ser.Deserialize<Person>(JSONstring);
            Console.WriteLine(p1);
            Console.ReadLine();
        }
    }
}
