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

            Console.WriteLine();
            Console.WriteLine("Opgave 3");
            Console.WriteLine("Test af klassen");
            Console.WriteLine($"{member1}");
            Console.WriteLine($"{member2}");
            Console.WriteLine($"{member3}");

          
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

            Console.WriteLine("Liste af hunde efter fjernelse af Pluto:");
            member1.PrintDogs();
            member2.PrintDogs();
            member3.PrintDogs();

            Console.WriteLine();
            Console.WriteLine("Opgave 6");
            Console.WriteLine("Test af aldersberegning");
            Console.WriteLine($"{member1.Name} is {member1.Age} years old.");
            Console.WriteLine($"{member2.Name} is {member2.Age} years old.");
            Console.WriteLine($"{member3.Name} is {member3.Age} years old.");

            Console.WriteLine();
            Console.WriteLine("Test af Memberfee");
            Console.WriteLine($"{member1.Name} med 1 hunde, 65 år, grundgebyr 1000: {member1.MemberFee(1000)}");
            Console.WriteLine($"{member2.Name} med 2 hund, 46 år, grundgebyr 1000: {member2.MemberFee(1000)}");
            Console.WriteLine($"{member3.Name} med 1 hunde, 27 år, grundgebyr 1000: {member3.MemberFee(1000)}");

        }
    }
}
