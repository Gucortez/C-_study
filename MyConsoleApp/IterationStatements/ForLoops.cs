namespace MyConsoleApp.IterationStatements
{
    public class ForLoops
    {
        public static void ForLoopsTests(int i)
        {
            for (i = 1; i <= 10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for(i = 10; i >= 1; i--)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
