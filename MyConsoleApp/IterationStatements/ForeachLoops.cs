namespace MyConsoleApp.IterationStatements
{
    public class ForeachLoops
    {
        public static void ForeachLoopsTests(string name)
        {
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }

        public static void ForeachLoopsArray(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

