//Write a program that receives some info from the console about people and their phone numbers.
//You are free to choose the manner in which the data is entered; each entry should have just one name and one number(both of them strings). 
//If you receive a name that already exists in the phonebook, simply update its number.After filling this simple phonebook, upon 
//receiving the command "search", your program should be able to perform a search of a contact by name and print her details 
//in format "{name} -> {number}". In case the contact isn't found, print "Contact {name} does not exist." Examples:


using System;
using System.Collections.Generic;
class Phonebook
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] nameAndNumber = input.Split('-');
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        phoneBook.Add(nameAndNumber[0], nameAndNumber[1]);
        while (input != "stop")
        {
            input = Console.ReadLine();
            if (input != "search")
            {
                string[] anotherNameAndNumber = input.Split('-');
                phoneBook.Add(anotherNameAndNumber[0], anotherNameAndNumber[1]);
            }
            else if (input == "search")
            {
                string name = Console.ReadLine();
                while(name!="stop")
                {
                if (phoneBook.TryGetValue(name, out nameAndNumber[1]))
                {
                    System.Console.WriteLine("{0} -> {1}", name, nameAndNumber[1]);
                }
                else
                {
                    System.Console.WriteLine("Contact {0} does not exist.", name);
                }
                    name = Console.ReadLine();
                }
            }
            
        }
        
    }
}