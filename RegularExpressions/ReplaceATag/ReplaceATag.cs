//Write a program that replaces in a HTML document given as string all the tags<a href=…>…</a> with corresponding tags[URL href =…>…[/ URL].
//Read an input, until you receive “end” command.Print the result on the console. 

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main()
    {
        string line = Console.ReadLine();
        string lastString = "";
        List<string> lines = new List<string>();

        while (line != "end")
        {
            Regex r = new Regex("(.*)(<a.*)(\".*\").+?(.*)(<\\/a>)(.*)");
            Match m = r.Match(line);

            if (m.Success)
            {
                string group1 = m.Groups[1].ToString();
                string group2 = "[URL href=";
                string group3 = m.Groups[3] + "]";
                string group4 = m.Groups[4].ToString();
                string group5 = "[/URL]";
                string group6 = m.Groups[6].ToString();

                lastString = group1 + group2 + group3 + group4 + group5 + group6;
                lines.Add(lastString);
                line = Console.ReadLine();
                continue;
            }

            lines.Add(line);
            line = Console.ReadLine();
        }
        foreach (var item in lines)
        {
            Console.WriteLine(item);
        }
    }
}