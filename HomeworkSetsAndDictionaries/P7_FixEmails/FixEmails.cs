//You are given a sequence of strings, each on a new line, unitll you receive “stop” command.First string is a name of a person.
//On the second line you receive his email.Your task is to collect their names and emails, and remove emails whose
//domain ends with "us" or "uk" (case insensitive). Print:
//{name} – > {email} 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            string name = System.Console.ReadLine();
            string email = System.Console.ReadLine();

            Dictionary<string, string> data = new Dictionary<string, string>();
            if (!email.Contains(".uk") || !email.Contains(".us")|| !email.Contains(".US")|| !email.Contains(".UK"))
            {
                data.Add(name, email);
            }
            while (name!="stop")
            {
                string nextName = System.Console.ReadLine();
                
                if (nextName=="stop")
                {
                    break;
                }
                string nextEmail = System.Console.ReadLine();
                string first = ".uk";
                string second = ".UK";
                string third = ".US";
                string fourth = ".us";
                if (nextEmail.Contains(first) || nextEmail.Contains(second)|| nextEmail.Contains(third) || nextEmail.Contains(fourth))
                {
                    continue;
                }
                else
                {
                    data.Add(nextName, nextEmail);
                    
                }
            }
            foreach (KeyValuePair<string, string> kvp in data)
            {
                System.Console.WriteLine(kvp.Key + " " + "->" + " " + kvp.Value);
            }
        }
    }
}
