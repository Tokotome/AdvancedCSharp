using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {

            SortedSet<string> alabala = new SortedSet<string>();
            alabala.Add("Gosho");
            alabala.Add("Posho");
            alabala.Add("Losho");
            string join = string.Join(",", alabala.ToArray());
            Console.WriteLine(join);

        }
    }
}