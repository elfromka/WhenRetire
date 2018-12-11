using System;
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

    class FirstProject
    {
        public static void Run()
        {
            Gender? genderEnum;

            // Check if the gender is entered correctly
            bool genderOk = false;

            genderEnum = null;

            do
            {
                Console.Write("Are you a Male(M) or Female(F)?: ");
                string gender = Console.ReadLine();

                if (gender == "M")
                {
                    genderEnum = Gender.Male;
                    genderOk = true;
                }
                else if (gender == "F")
                {
                    genderEnum = Gender.Female;
                    genderOk = true;
                }
                else
                {
                    Console.WriteLine("Invalid gender, you MUST enter 'M' or 'F'!");
                }
            }
            while (genderOk == false);

            Console.WriteLine("Please, enter your birthdate: ");
            Console.Write("Year: ");
            string stringBirthYear = Console.ReadLine();
            Console.Write("Month: ");
            string stringBirthMonth = Console.ReadLine();
            Console.Write("Day: ");
            string stringBirthDay = Console.ReadLine();

            // Converting to int
            int birthYear = int.Parse(stringBirthYear);
            int birthMonth = int.Parse(stringBirthMonth);
            int birthDay = int.Parse(stringBirthDay);
            DateTime dateOfBirth = new DateTime(birthYear, birthMonth, birthDay);

            // Calculate the age of the person
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dateOfBirth.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;

            // Give response depending on the age of the person
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
        }

    }

}
