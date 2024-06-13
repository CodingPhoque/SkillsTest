namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(1, "Pluto", "Bulldog", 2017);
            Dog dog2 = new Dog(2, "Coco", "Fransk bulldog", 2018);
            Dog dog3 = new Dog(3, "Kenzo", "Golden Retriever", 2020);

            Console.WriteLine("Opgave 2");
            Console.WriteLine("Test af klassen");
            Console.WriteLine($"{dog1}");
            Console.WriteLine($"{dog2}");
            Console.WriteLine($"{dog3}");

            Member member1 = new Member(1, "Jens Peter", "Zealand Roskilde",new DateTime(1958,6,20),"+4512345678", "jenspeter@zealand.dk");
            Member member2 = new Member(2, "Jakob", "Zealand Roskilde", new DateTime(1976,3,15), "+4587654321", "jakob@zealand.dk");
            Member member3 = new Member(3, "Mikkel", "Køge", new DateTime(1997,4,7), "+4521345678", "mikkel@zealand.dk");
            Member member4 = new Member(4, "Jonas", "Roskilde", new DateTime(2009, 5, 8), "+4586754321", "jonas@zealand.dk");
            Member member5 = new Member(5, "Lasse", "", new DateTime(2000, 8, 9), "", "");

            Console.WriteLine();
            Console.WriteLine("Opgave 3");
            Console.WriteLine("Test af klassen");
            Console.WriteLine($"{member1}");
            Console.WriteLine($"{member2}");
            Console.WriteLine($"{member3}");
            Console.WriteLine($"{member4}");
            Console.WriteLine($"{member5}");

            
            member1.RegisterDog(dog1);
            member1.RegisterDog(dog2);
            member2.RegisterDog(dog1);
            member2.RegisterDog(dog2);
            member3.RegisterDog(dog3);


            Console.WriteLine();
            Console.WriteLine("Opgave 4");
            Console.WriteLine("Test af CRUD");
            Console.WriteLine("Liste af hunde:");
            member1.PrintDogs();
            member2.PrintDogs();

            member1.RemoveDog(dog1);
            Console.WriteLine();
            Console.WriteLine("Liste af hunde efter fjernelse af første Pluto:");
            member1.PrintDogs();
            member2.PrintDogs();
            member3.PrintDogs();

            Console.WriteLine();
            Console.WriteLine("Opgave 6");
            Console.WriteLine("Test af aldersberegning");
            Console.WriteLine($"{member1.Name} is {member1.Age} years old.");
            Console.WriteLine($"{member2.Name} is {member2.Age} years old.");
            Console.WriteLine($"{member3.Name} is {member3.Age} years old.");
            Console.WriteLine($"{member4.Name} is {member4.Age} years old.");

            Console.WriteLine();
            Console.WriteLine("Opgave 7");
            Console.WriteLine("Test af Memberfee");
            Console.WriteLine($"{member1.Name} med 1 hunde, 65 år, pris: {member1.MemberFee(1000)} DKK, senior pris opnået");
            Console.WriteLine($"{member2.Name} med 2 hund, 46 år, pris: {member2.MemberFee(1000)} DKK, halv pris opnået på hund nr2");
            Console.WriteLine($"{member3.Name} med 1 hunde, 27 år, pris: {member3.MemberFee(1000)} DKK");

            /*Console.WriteLine();
            Console.WriteLine("Opgave 7");
            Console.WriteLine("Validering af data");
            Console.WriteLine($"{member1.Name} - Validering: {member1.Validate()}");
            Console.WriteLine($"{member2.Name} - Validering: {member2.Validate()}");
            Console.WriteLine($"{member3.Name} - Validering: {member3.Validate()}");
            Console.WriteLine($"{member4.Name} - Validering: {member4.Validate()}");
            Console.WriteLine($"{member5.Name} - Validering: {member5.Validate()}");
            */
            Console.WriteLine();
            Console.WriteLine("Opgave 8");
            Console.WriteLine("Exception handling");
            Console.WriteLine();
            Console.WriteLine("Test af medlem 3");
            try
            {
                member3.Validate();
                Console.WriteLine("Medlem valideret succesfuldt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            Console.WriteLine("Test af medlem 4");
            try
            {
                member4.Validate();
                Console.WriteLine("Medlem valideret succesfuldt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            Console.WriteLine("Test af medlem 5");
            try
            {
                member5.Validate();
                Console.WriteLine("Medlem valideret succesfuldt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
