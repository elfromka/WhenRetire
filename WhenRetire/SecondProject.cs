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

            Console.WriteLine("Using string1 and string2: ");
            Console.WriteLine("String1: {0}", string1);
            Console.WriteLine("String2: {0}", string2);

            // method 1
            Console.WriteLine("\r\nUsing .ToUpper() for string1");
            Console.WriteLine(string1.ToUpper());

            // method 2
            Console.WriteLine("\r\nUsing string.IsNullOrEmpty() for string1");
            Console.WriteLine(string.IsNullOrEmpty(string1));

            // method 3
            Console.WriteLine("\r\nUsing string.Concat() with string1 and string2");
            Console.WriteLine(string.Concat(string1, string2));

            // method 4
            Console.WriteLine("\r\nUsing string.Compare() with string1 and string2");
            int compare = string.Compare(string1, string2);
            Console.WriteLine(compare);

            // method 5
            Console.WriteLine("\r\nUsing string.Replace(), replacing word: 'homework' to 'first string'");
            string replacedString = string1.Replace("homework", "first string");
            Console.WriteLine(replacedString);

            // method 6
            Console.WriteLine("\r\nUsing string.Remove() for string2 removing last 6 characters");
            string removeString2 = string2.Remove(string2.Length - 6);
            Console.WriteLine(removeString2);

            // method 7
            Console.WriteLine("\r\nUsing string.Trim()");
            string stringForTrim = " This is a new string  ";
            Console.WriteLine("Initial string: {0}", stringForTrim);
            stringForTrim = stringForTrim.Trim();
            Console.WriteLine("After using Trim(): {0}", stringForTrim);

            Console.ReadKey();
        }
    }
}
