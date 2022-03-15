using System;
using Access_modifiers_and_Encapsulation.Models;

namespace Access_modifiers_and_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Name
            Console.Write("Enter name : ");
            string name = Console.ReadLine();
            #endregion

            #region Surname
            Console.Write("Enter Surname : ");
            string surname = Console.ReadLine();
            #endregion

            #region Age
            Console.Write("Enter age : ");
            ReEnterAge:
            int age = 0;
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                if (age > 0 && age < 150)
                {}
                else
                {
                    Console.Clear();
                    Console.Write("Error!!!\nPlease enter age again : ");
                    goto ReEnterAge;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.Write("Error!!!\nPlease enter age again : ");
                goto ReEnterAge;
            }
            #endregion

            #region Experience
            Console.Write("Enter experience year : ");
            ReEnterExperience:
            int experience = 0;
            try
            {
                experience = Convert.ToInt32(Console.ReadLine());
                if(experience > 0 && experience < (age - experience))
                {}
                else
                {
                    Console.Clear();
                    Console.Write("Error!!!\nPlease enter experience year again : ");
                    goto ReEnterExperience;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.Write("Error!!!\nPlease enter experience year again : ");
                goto ReEnterExperience;
            }
            #endregion

            #region Languages

            Console.Write("How many languages person know ? : ");
            ReEnterLanguageCount:
            int languageCount = 0;

            try
            {
                languageCount = (Convert.ToInt32(Console.ReadLine()));
                if (languageCount > 0 && languageCount < 30)
                {}
                else
                {
                    Console.Clear();
                    Console.Write("Error!!! Please re-enter count of languages (ex. 5) : ");
                    goto ReEnterLanguageCount;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.Write("Error!!! Please re-enter count of languages (ex. 5) : ");
                goto ReEnterLanguageCount;
            }

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
            #endregion

            FrontEnd frontEnd = new FrontEnd(name, surname, age, experience, languages);
            BackEnd backEnd = new BackEnd(name, surname, age, experience, languages);

            Console.WriteLine(frontEnd.GetFullName());
            Console.WriteLine(frontEnd.AddYearsExperience(5));

            Console.WriteLine(backEnd.GetFullName());
            Console.WriteLine(backEnd.AddYearsExperience(5));
        }
    }
}
