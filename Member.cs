using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Member
    {
        // Constructor
        public Member(int id, string name, string address, DateTime birthDate, string phone, string email)
        {
            ID = id;
            Name = name;
            Address = address;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            Dog = new List<Dog>();
        }



        // Properties
        public int ID   // Medlems ID, som skal være unik
        { get; set; }

        public string Name  // Fornavn og efternavn
        { get; set; }

        public string Address // Hele adressen
        { get; set; }

        public DateTime BirthDate   // Fødselsdato
        { get; set; }

        public string Phone // Telefon nummer med landekode
        { get; set; }

        public string Email // Email
        { get; set; }

        public List<Dog> Dog
        { get; set; }

        // Opgave 6
        public int Age
            { get
                { return DateTime.Now.Year - BirthDate.Year; }
            }

        // Opgave 6
        public double MemberFee(double baseFee)
        {
            double totalFee = baseFee;
            // Over 65
            if (Dog.Count > 0 && Age >= 65)
            {
                totalFee = 0.5 * baseFee;
            }
            // Fuld pris første hund
            else if (Dog.Count > 0) 
            {
                totalFee = baseFee;
            }
            // Halv pris på efterfølgende
            for (int i = 1; i < Dog.Count; i++)
            {
                totalFee += 0.5 * baseFee;
            }

            return totalFee;
        }   



        // ToString Method
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Address: {Address}, Birth date: {BirthDate}, Phone: {Phone}, Email: {Email}";
        }

        // Opgave 4: Create
        public void RegisterDog(Dog dog)
            {
            Dog.Add(dog);
        }

        // Opgave 4
        public void PrintDogs()
        {
            foreach (Dog dog in Dog)
            {
                Console.WriteLine(dog);
            }
        }

        
        // Opgave 4: Remove
        public bool RemoveDog(Dog dog)
        {
            return Dog.Remove(dog); 
        }
    }
}
