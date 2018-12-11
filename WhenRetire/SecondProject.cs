using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhenRetire
{
    class SecondProject
    {
        public static void Run()
        {
            string string1 = "This is my homework";
            string string2 = "This is my second string";

            // method 1
            Console.WriteLine("\r\nUsing .ToUpper()");
            Console.WriteLine(string1.ToUpper());

            // method 2
            Console.WriteLine("\r\nUsing string.IsNullOrEmpty()");
            Console.WriteLine(string.IsNullOrEmpty(string1));

            // method 3
            Console.WriteLine("\r\nUsing string.Concat()");
            Console.WriteLine(string.Concat(string1, string2));

            // method 4
            Console.WriteLine("\r\nUsing string.Compare()");
            int compare = string.Compare(string1, string2);
            Console.WriteLine(compare);

            // method 5
            Console.WriteLine("\r\nUsing string.Replace()");
            string replacedString = string1.Replace("homework", "first string");
            Console.WriteLine(replacedString);

            // method 6
            Console.WriteLine("\r\nUsing string.IsNullOrEmpty()");
            bool check = string.IsNullOrEmpty(string1);
            Console.WriteLine(check);

            // method 7
            Console.WriteLine("\r\nUsing string.Trim()");
            string stringForTrim = " This is a new string  ";
            Console.WriteLine(stringForTrim);
            stringForTrim = stringForTrim.Trim();
            Console.WriteLine(stringForTrim);

            Console.ReadKey();
        }
    }
}
