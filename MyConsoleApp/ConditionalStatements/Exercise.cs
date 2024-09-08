using System.Runtime.CompilerServices;

namespace MyConsoleApp.ConditionalStatements
{
    public class Exercise
    {
        public static void NumberValidation()
        {
            Console.WriteLine("Enter a number between 1 and 10: ");
            int number  = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <=10)
            {
                Console.WriteLine("Valid");
            }else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static int MaxNumber()
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                return num1;
            }else
            {
                return num2;
            }
        }

        public static void LandscapeOrPortrait()
        {
            Console.Write("Image width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Landscape");
            }else
            {
                Console.WriteLine("Portrait");
            }
        }

        public static void SpeedTest()
        {
            Console.Write("What is the speed limit on this road? ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What was the car speed? ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }else
            {
                var demeritPoints = (carSpeed - speedLimit)/5;
                if (demeritPoints < 12)
                {
                    Console.WriteLine("Your demerit points are: "+ demeritPoints);
                }else
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}