namespace MyConsoleApp.People
{
    public class Person
    {
        public string? FirstName;
        public string? LastName;
        public int? Age;
        public void Introduce()
        {
            System.Console.WriteLine("My name is " + FirstName + " "+ LastName);
        }
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age +=10;
        }
    }
};