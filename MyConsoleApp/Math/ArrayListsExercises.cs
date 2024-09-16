namespace MyConsoleApp.Math
{
    public class ArrayListsExercises
    {
        public static void Exercise1()
        {
            Console.WriteLine("Who liked you? Enter their names below: ");

            var names = new List<string>();
            while (true)
            {
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    break;
                
                names.Add(name);

                Console.WriteLine("Add another name or press Enter to finish: ");
            }
            if (names.Count > 3)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others thought you were great!");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} thought you were awesome!");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} really liked you!");
            }
            else
            {
                Console.WriteLine("Looks like no one was mentioned this time, but that's okay!");
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputName))
            {
                Console.WriteLine("You didn't enter a name!");
            }
            else
            {
                char[] reverseInputName = inputName.Reverse().ToArray();
                Console.WriteLine($"Your name reversed {new string(reverseInputName)}");
            }
        }

        public static void Exercise3()
        {
        Console.WriteLine("Give me five numbers:");

        var numbers = new List<int>();
        
        while (numbers.Count < 5)
        {
            Console.Write($"Enter number {numbers.Count + 1 }: ");
            
            string inputNumber = Console.ReadLine();
            if (int.TryParse(inputNumber, out int number))
            {
                if (numbers.Contains(number))
                {
                    Console.WriteLine("This number has already been entered. Please enter a different number.");
                }
                else
                {
                    numbers.Add(number);
                }
            } 
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            
            if (numbers.Count < 5)
            {
                Console.WriteLine($"You need to enter {5 - numbers.Count} more numbers.");
            }
        }

            numbers.Sort();
            Console.WriteLine("You have entered five numbers.");
            Console.WriteLine($"The numbers you entered are: {string.Join(", ", numbers)}");
        }

        public static void Exercise4()
        {
            Console.WriteLine("Give me numbers:");

            var numbers = new List<int>();

            while (true)
            {
                var inputNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputNumber))
                    break;
                if (string.Equals(inputNumber.Trim(), "quit", StringComparison.InvariantCultureIgnoreCase))
                    break;

                numbers.Add(Convert.ToInt32(inputNumber));

                Console.Write("Enter number or type 'quit': ");
            }

                var uniqueNumbers = numbers.Distinct().ToList();
                uniqueNumbers.Sort();
                Console.WriteLine($"The sorted unique numbers are: {string.Join(", ", uniqueNumbers)}");

        }

        public static void Exercise5()
        {
            Console.WriteLine("Please enter a list of comma-separated numbers (e.g., 5, 1, 9, 2, 10): ");

            while (true)
            {
                string inputList = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputList))
                    break;

                var numberStrings = inputList.Split(','); // Split the input into individual numbers
                var numbers = new List<int>();

                foreach (var numStr in numberStrings)
                {
                    if (int.TryParse(numStr.Trim(), out int number)) 
                    /*numStr.Trim(): Removes any extra spaces from the string numStr.

                     int.TryParse(numStr.Trim(), out int number): Attempts to convert the trimmed string into an integer. 
                     If the conversion is successful, it stores the result in the number variable and returns true. 
                     If it fails, it returns false, and number is set to 0 (default value for int).

                    if (...): The if statement checks whether the conversion was successful by examining the result of TryParse. 
                    If it was successful, you can use number for further operations. If it was not successful, you handle the failure case 
                    (e.g., by prompting the user to enter a valid number). */
                    
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter valid integers separated by commas.");
                        numbers.Clear(); // Clear the list if any number is invalid
                        break;
                    }
                }

                if (numbers.Count < 5) // Check if the list has less than 5 numbers
                {
                    Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                    continue; // Ask the user to re-try
                }

                var sortedNumbers = numbers.Distinct().ToList(); // Remove duplicates
                sortedNumbers.Sort(); // organize the numbers by value

                if (sortedNumbers.Count >= 3)
                {
                    Console.WriteLine("The 3 smallest numbers are: " +
                                      $"{sortedNumbers[0]}, {sortedNumbers[1]}, {sortedNumbers[2]}"); // take the first three (smallest values)
                }
                else
                {
                    Console.WriteLine("The list does not contain at least 3 unique numbers.");
                }
                break; // Exit the loop once a valid list is processed
            }
        }
    }
}