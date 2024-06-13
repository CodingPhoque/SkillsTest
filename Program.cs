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

            Member member1 = new Member(1, "Jens Peter", "Zealand Roskilde",DateTime.Now,"+4512345678", "jenspeter@zealand.dk");
            Member member2 = new Member(2, "Jakob", "Zealand Roskilde", DateTime.Now, "+4587654321", "jakob@zealand.dk");
            Member member3 = new Member(3, "Mikkel", "Køge", DateTime.Now, "+4521345678", "mikkel@zealand.dk");

            Console.WriteLine();
            Console.WriteLine("Opgave 3");
            Console.WriteLine("Test af klassen");
            Console.WriteLine($"{member1}");
            Console.WriteLine($"{member2}");
            Console.WriteLine($"{member3}");

          
            member1.RegisterDog(dog1);
            member2.RegisterDog(dog2);

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
        }
    }
}
