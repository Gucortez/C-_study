namespace MyConsoleApp.IterationStatements
{
    public class WhileLoops
    {
        public static void EcoProgram()
        {
            string input;

            while (true)
            {
                Console.Write("Type your name: ");
                input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                    break;
            }
        }
    }
}
