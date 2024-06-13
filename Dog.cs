using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SkillsTest
{
    public class Dog
    {
        // Constructor
        public Dog(int id, string name, string race, int yearOfBirth)
        {
            ID = id;
            Name = name;
            Race = race;
            YearOfBirth = yearOfBirth;
        }


        // Properties
        public int ID   // Hundens ID, som skal være unik - f.eks. 101
        { get; set; }
       
        public string Name  // Hundens navn – f.eks. ”Pluto”
        { get; set; }
       
        public string Race  // Hundens race – f.eks. ”Bulldog”
        { get; set; }

        public int YearOfBirth  // Hundens fødselsår – f.eks. 2017
        { get; set; }


        // ToString Method
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Race: {Race}, Year of birth: {YearOfBirth}";
        }






    }
}
