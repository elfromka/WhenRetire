using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WhenRetire
{
    public enum Gender
    {
        Male,
        Female
    }

    class FirstProject
    {
        static DateTime ReadBirthDay()
        {
            Console.WriteLine("Please, enter your birthdate: ");
            Console.Write("Year: ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.Write("Day: ");
            int birthDay = int.Parse(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(birthYear, birthMonth, birthDay);
            return dateOfBirth;
        }

        public static void Run()
        {
            Gender? genderEnum;

            // Check if the gender is entered correctly
            bool isGenderValid = false;

            genderEnum = null;

            do
            {
                Console.Write("Are you a Male(M) or Female(F)?: ");
                string gender = Console.ReadLine().Trim().ToLower();

                if (gender == "m")
                {
                    genderEnum = Gender.Male;
                    isGenderValid = true;
                }
                else if (gender == "f")
                {
                    genderEnum = Gender.Female;
                    isGenderValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid gender, you MUST enter 'm' or 'f'!");
                }
            }
            while (isGenderValid == false);

            DateTime dateOfBirth = ReadBirthDay();

            // Calculate the age of the person
            DateTime now = DateTime.Now;
            TimeSpan difference = now.Subtract(dateOfBirth);
            var age = difference.TotalDays / 365.25;

            // Give response depending on the age of the person
            switch (genderEnum)
            {
                case Gender.Female:
                    if (age < 63)
                    {
                        Console.WriteLine("You will retire at age 63");
                    }
                    else
                    {
                        Console.WriteLine("You are retired");
                    }
                    break;

                case Gender.Male:
                    if (age < 65)
                    {
                        Console.WriteLine("You will retire at age 65");
                    }
                    else
                    {
                        Console.WriteLine("You are retired");
                    }
                    break;
            }
            Console.WriteLine();

        }
    }
}
