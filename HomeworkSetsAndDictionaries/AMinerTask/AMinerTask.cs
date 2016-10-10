//You are given a sequence of strings, each on a new line.Every odd line on the console is representing a resource
//(e.g.Gold, Silver, Copper, and so on) , and every even – quantity.Your task is to collect the resources and print 
//them each on a new line.Print the resources and their quantities in format:
//{resource} –> {quantity}
//The quantities inputs will be in the range[1 … 2 000 000 000]


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            
            Dictionary<string, List<Int32>> data = new Dictionary<string, List<Int32>>();
            while (resource != "stop")
            {
                Int32 ammount = Int32.Parse(Console.ReadLine());
                
                if (resource != "stop" && !data.ContainsKey(resource))
                {
                    ammount = int.Parse(Console.ReadLine());
                    data.Add(resource, new List<Int32>());
                    data[resource].Add(ammount);
                }
                else if (resource != "stop" && data.ContainsKey(resource))
                {
                    ammount = int.Parse(Console.ReadLine());
                    data[resource].Add(ammount);
                }
                else
                {
                    break;
                }

            }

            
            data.Add(resource, new List<Int32>());
            
            
            foreach (KeyValuePair<string, List<Int32>> kvp in data)
            {
                System.Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value.Sum());
            }
        }
    }
}
