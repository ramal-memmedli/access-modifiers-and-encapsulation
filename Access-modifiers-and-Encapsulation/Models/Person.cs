using System;

namespace Access_modifiers_and_Encapsulation.Models
{
    public class Person
    {
        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public int Age { get { return _age; } set { if (value > 0 && value < 150) _age = value; } }

        public Person()
        {

        }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        /// <summary>
        /// Returns developer's full name.
        /// </summary>
        /// <returns>String type full name.</returns>
        public string GetFullName()
        {
            return this.Name + " " + this.Surname;
        }

        private string _name;
        private string _surname;
        private int _age;
    }
}
