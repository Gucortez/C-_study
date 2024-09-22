using System.Text;

namespace MyConsoleApp.Strings
{
    public class StringBuilderTests
    {
        public static void StringBuilder()
        {
            var builder = new StringBuilder("Hello World"); // starting string
            
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);
            Console.WriteLine(builder);

            builder.Replace('-', '+');
            Console.WriteLine(builder);

            builder.Remove(0, 10); // remove 10 characters
            Console.WriteLine(builder);

            builder.Insert(0, new string('-',10)); 
            // Inserts a string into this instance at the specified character position.
            Console.WriteLine(builder);

            Console.WriteLine($"First char: {builder[0]}");

        }
    }
}