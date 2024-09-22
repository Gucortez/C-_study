namespace MyConsoleApp.Strings
{
    public class Exercises
    {    
        public static void LiveCoding()
        {
            var longSentence = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            var summary = SummerizeText(longSentence, 30);
            Console.WriteLine(summary);
        }

        static string SummerizeText(string text, int maxLength = 20) // default value for maxLength
        {

            if (text.Length < maxLength)
                return text;

            var words = text.Split(' '); // string array of words, to not cut any text in the middle of words
            var totalChar = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalChar += word.Length + 1; // +1 is because of the spaces
                if (totalChar > maxLength)
                    break;
            }
            
            return String.Join(" ", summaryWords) + "...";
        }

        // Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. 
        // For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

        public static void Exercise1()
        {
            Console.WriteLine("Please enter a list of hyphen-separated numbers (e.g., 5-1-9-2-10): ");

            while (true)
            {
                string inputList = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputList))
                    break;
                var numbers = new List<int>();
                foreach (var number in inputList.Split('-'))
                    numbers.Add(Convert.ToInt32(number));
                numbers.Sort();
                var isConsecutive = true;

                for (var i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] != numbers[i - 1] + 1)
                    {
                        isConsecutive = false;
                        break;
                    }
                }
                var uniques = new List<int>();
                var includesDuplicates = false;
                foreach (var number in numbers)
                {
                    if (!uniques.Contains(number))
                        uniques.Add(number);
                    else
                    {
                        includesDuplicates = true;
                        break;
                    }
                }

                if (includesDuplicates)
                    Console.WriteLine("Includes Duplicates");
                var message = isConsecutive ? "Consecutive" : "Not Consecutive";
                Console.WriteLine(message);
            }
        }

        public static void Exercise2()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            
            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

        public static void Exercise3()
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }

        public static void Exercise4()
        {
            Console.Write("Enter a word: ");
            // Note the ToLower() here. This is used to count for both A and a. 
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] {'a', 'e', 'o', 'u', 'i'});
            var vowelsCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
