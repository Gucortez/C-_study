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
    }
}
