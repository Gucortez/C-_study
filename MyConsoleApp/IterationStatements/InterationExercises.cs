namespace MyConsoleApp.IterationStatements
{
    public class InterationExercises
    {
        public static void CountNumbers()
        {
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void OkExercise()
        {
            int sum = 0;

            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input == null)
                {
                    break;
                }

                if (input.Equals("ok", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                } 

                if (int.TryParse(input, out int number))
                {
                    sum += number;
                }
            }
            Console.WriteLine("Sum of numbers: " + sum);
        }

        public static void NumberFactorial()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(number + "! = " + factorial);
        }

        public static void RandomNumber()
        {
            var randomNumber = new Random().Next(1, 10);

            // Console.WriteLine("The Random number is " + randomNumber); //test

            Console.WriteLine("Try to guess the number between 1 and 10!");

                for (var i = 4; i > 0; i--)
                 {
                    Console.Write("Attempts remaining: " + i + ". Enter your guess: ");
                    var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomNumber)
                {
                    Console.WriteLine("You got it!");
                    return;
                }
            }

            Console.WriteLine("You lost!");
        }

        public static void SeriesOfNumbers()
        {
            Console.WriteLine("Enter a serie of numbers separated by commas: ");
            var input = Console.ReadLine();
            var numbers = input?.Split(",");
            var maxNumber = Convert.ToInt32(numbers?[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if(number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine("The max number is: "+ maxNumber);
        }
    }
}