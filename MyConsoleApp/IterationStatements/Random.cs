namespace MyConsoleApp.IterationStatements
{
    public class RandomClass
    {
        public static void RandomTests()
        {
            var random = new Random();

            const int passwordLenght = 10;

            var buffer = new char[passwordLenght]; //size of the array

            for (var i = 0; i < passwordLenght; i++)
            {
                buffer[i] = (char)('a' + random.Next(0,26));  //MinMax Value
            }
            
            var password = new string(buffer);
            Console.WriteLine(password);

            Console.WriteLine((int)'a'); //ASCII ascii-code.com, value of the letters
        }
    }
}

