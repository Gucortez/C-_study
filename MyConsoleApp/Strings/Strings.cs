namespace MyConsoleApp.Strings
{
    public class StringsTests
    {
        public static void Strings()
        {
            var fullName = "Gustavo Cortez ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index+1);
            Console.WriteLine($"Substring and index: {firstName} {lastName}");

            var names = fullName.Split(' ');
            Console.WriteLine("FirsName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Gustavo", "Noah"));
            Console.WriteLine(fullName.Replace("o", "O"));

            if(String.IsNullOrEmpty(" ".Trim())) // catch when the user press space
                Console.WriteLine("Invalid");

            if(String.IsNullOrWhiteSpace(" ")) // no need for the trim anymore
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str); // converting to integer, in this case age, so can be small as a byte
            Console.WriteLine(age);

            float price = 29.95f;
            System.Console.WriteLine(price.ToString("C0")); // C to make it money, and 0 for the decimal.
        }
    }
}
