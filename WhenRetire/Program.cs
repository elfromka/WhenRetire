﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhenRetire
{
    public enum Gender
    {
        Male,
        Female
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Homework 1");
            Console.WriteLine("Retired or not", Environment.NewLine);

            Console.Write("Are you a Male(M) or Female(F)?: ");
            string gender = Console.ReadLine();
            Gender? genderEnum;

            if (gender == "M")
            {
                genderEnum = Gender.Male;
            }
            else if (gender == "F")
            {
                genderEnum = Gender.Female;
            }
            else
            {
                genderEnum = null;
                Console.WriteLine("You MUST enter 'M' or 'F'!");
            }

            Console.WriteLine("Please, enter your birthdate: ");
            Console.Write("Year: ");
            string stringBirthYear = Console.ReadLine();
            Console.Write("Month: ");
            string stringBirthMonth = Console.ReadLine();
            Console.Write("Day: ");
            string stringBirthDay = Console.ReadLine();
            int birthYear = int.Parse(stringBirthYear);
            int birthMonth = int.Parse(stringBirthMonth);
            int birthDay = int.Parse(stringBirthDay);
            DateTime dateOfBirth = new DateTime(birthYear, birthMonth, birthDay);
          
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dateOfBirth.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;

            if ((age >= 63 && (genderEnum == Gender.Female)) || (age >= 65 && (genderEnum == Gender.Male)))
            {
                Console.WriteLine("You are retired");
            }
            else if (age < 63 && (genderEnum == Gender.Female))
            {
                Console.WriteLine("You will retire at age 63");
            }
            else if (age < 65 && (genderEnum == Gender.Male))
            {
                Console.WriteLine("You will retire at age 65");
            }
            Console.WriteLine();

            Console.WriteLine("Homework 2");
            string string1 = "This is my homework";
            string string2 = "This is my second string";
            string stringForTrim = " This is a new string  ";

            // method 1
            Console.WriteLine(string1.ToUpper());

            // method 2
            Console.WriteLine(string.IsNullOrEmpty(string1));

            // method 3
            Console.WriteLine(string.Concat(string1, string2));

            // method 4
            int compare = string.Compare(string1, string2);
            Console.WriteLine(compare);

            // method 5
            string replacedString = string1.Replace("homework", "first string");
            Console.WriteLine(replacedString);

            // method 6
            bool check = string.IsNullOrEmpty(string1);
            Console.WriteLine(check);

            // method 7
            stringForTrim = stringForTrim.Trim();
            Console.WriteLine(stringForTrim);

            Console.ReadKey();
        }
    }
}