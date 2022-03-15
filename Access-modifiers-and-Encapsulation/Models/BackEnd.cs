using System;

namespace Access_modifiers_and_Encapsulation.Models
{
    public class BackEnd : Developer
    {
        public string[] Languages { get { return _languages; } set { _languages = value; } }

        public BackEnd(string name, string surname, int age, int experience, string[] languages) : base(name, surname, age, experience)
        {
            Languages = languages;
        }

        private string[] _languages;
    }
}
