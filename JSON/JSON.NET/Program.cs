using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSON.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            String JSONstring = File.ReadAllText("JSON.json");
            Person p1 = JsonConvert.DeserializeObject<Person>(JSONstring);
            Console.WriteLine(p1);

            Person p2 = new Person() {name = "Ben", age = 100};
            string OutputJSON = JsonConvert.SerializeObject(p2);
            File.WriteAllText("Output.json", OutputJSON);
        }
    }
}
