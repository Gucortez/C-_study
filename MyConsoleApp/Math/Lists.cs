
namespace MyConsoleApp.Math

{
    public class ListsTests
    {
        public static void Lists()
        {
            var numbers = new List<int>() { 1 , 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7});

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1)); // first time 1 appears
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1)); // last time 1 appears

            Console.WriteLine("Count: " + numbers.Count);

            // numbers.Remove(1); // removed the first one
            // foreach (var number in numbers)
            //     Console.WriteLine(number);

            for (var i = 0; i < numbers.Count; i++) // using for because I can't alter the list using foreach loops
            {
                if (numbers[i] == 1)
                numbers.Remove(numbers[i]);
            } // remove all the 1 in the list

            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.Clear(); // clear list
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}