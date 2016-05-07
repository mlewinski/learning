using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSONDataStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading data.json");
            string jsonString = File.ReadAllText("data.json");
            List<Item> myList = JsonConvert.DeserializeObject<List<Item>>(jsonString);

            if(myList == null) myList = new List<Item>();

            string input = "";
            int inputInt = 0;
            string inputString = "";
            while (input != "Q")
            {
                Console.WriteLine("A - Add");
                Console.WriteLine("D - Delete");
                Console.WriteLine("S - Show");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("Enter the command : ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                        Console.WriteLine("Name: ");
                        inputString = Console.ReadLine();
                        Console.WriteLine("Price: ");
                        inputInt = Convert.ToInt32(Console.ReadLine());
                        myList.Add(new Item(inputString, inputInt));
                        Console.WriteLine("Added {0} with price {1}", inputString, inputInt);
                        break;
                    case "D":
                        Console.WriteLine("Name: ");
                        inputString = Console.ReadLine();
                        myList.Remove(new Item(inputString));
                        Console.WriteLine("Deleted {0}", inputString);
                        break;
                    case "Q":
                        Console.WriteLine("Program closing!");
                        break;
                    case "S":
                        foreach (Item item in myList)
                        {
                            Console.WriteLine("Item : {0} | {1} zl", item.name, item.price);
                        }
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.WriteLine("Incorrect command");
                        break;
                }
            }
            Console.WriteLine("Saving changes to data.json");
            string data = JsonConvert.SerializeObject(myList);
            File.WriteAllText("data.json", data);
            Console.WriteLine("Saved");
            Console.ReadLine();
        }
    }
}
