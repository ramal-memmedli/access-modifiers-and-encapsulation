using System;

namespace Access_modifiers_and_Encapsulation.Models
{
    public class Developer : Person
    {
        public int Experience { get { return _experience; } set { if (value > 0 && value < Age) _experience = value; } }


        public Developer(string name, string surname, int age, int experience) : base(name, surname, age)
        {
            Experience = experience;
        }


        /// <summary>
        /// Adds years of experience to developer.
        /// </summary>
        /// <param name="addExperience">Experience years</param>
        /// <returns>Integer type experience year.</returns>
        public int AddYearsExperience(int addExperience)
        {
            int maxAddExperience = Age - Experience;

            if(addExperience > 0 && addExperience < maxAddExperience)
            {
                Experience = addExperience + _experience;
            }
            return Experience;
        }

        private int _experience = 0;
    }
}
