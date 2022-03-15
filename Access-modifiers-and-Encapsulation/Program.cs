using System;
using Access_modifiers_and_Encapsulation.Models;

namespace Access_modifiers_and_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = GetStringInput("Enter name : ");
            string surname = GetStringInput("Enter Surname : ");
            int age = GetNumberInput("Enter age : ","Error!!!, Please re-enter age : ",0,150);
            int experience = GetNumberInput("Enter experience year : ", "Error!!!\nPlease enter experience year again : ",0,age);
            int languageCount = GetNumberInput("How many languages person know ? : ", "Error!!! Please re-enter count of languages (ex. 5) : ",0,30);



            string languageInput;
            string[] languages = new string[languageCount];
            int counter = 1;

            for (int i = 0; i < languageCount; i++)
            {
                Console.Write($"Language {counter} : ");
                languageInput = Console.ReadLine();
                languages[i] = languageInput;
                counter++;
            }

            FrontEnd frontEnd = new FrontEnd(name, surname, age, experience, languages);
            BackEnd backEnd = new BackEnd(name, surname, age, experience, languages);

            Console.WriteLine(frontEnd.GetFullName());
            Console.WriteLine(frontEnd.AddYearsExperience(5));

            Console.WriteLine(backEnd.GetFullName());
            Console.WriteLine(backEnd.AddYearsExperience(5));
        }
        static string GetStringInput(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
        static int GetNumberInput(string msg, string msg2,int minimum, int maximum)
        {
            Console.Write(msg);
            ReEnterNumber:
            int number = 0;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                if(number > minimum && number < maximum) { } else
                {
                    Console.Clear();
                    Console.Write(msg2);
                    goto ReEnterNumber;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.Write(msg2);
                goto ReEnterNumber;
            }
            return number;
        }
    }
}
