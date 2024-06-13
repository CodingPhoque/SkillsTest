using System;
using System.Collections.Generic;
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

        // ToString Method
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Address: {Address}, Birth date: {BirthDate}, Phone: {Phone}, Email: {Email}";
        }

        // Create
        public void RegisterDog(Dog dog)
        {
            Dog.Add(dog);
        }

        
        public void PrintDogs()
        {
            foreach (Dog dog in Dog)
            {
                Console.WriteLine(dog);
            }
        }

        
        // Remove
        public bool RemoveDog(Dog dog)
        {
            return Dog.Remove(dog); 
        }
    }
}
