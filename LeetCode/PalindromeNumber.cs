public class PalindromeNumber {
    public static bool IsPalindrome(int number) {
        int ReverseNumber = 0;
        int TempNumber = number;  

        while (TempNumber > 0) // Ensure that TempNumber is greater than 0 and discard the last digit in each loop.
        {
            int LastDigit = TempNumber % 10; // takes the last digit of the number
            ReverseNumber = ReverseNumber * 10 + LastDigit; // shifts all digits one place to the left ex: 12 = 120 and adds the last digit
            TempNumber = TempNumber / 10;
        }
    if (number == ReverseNumber)
        {
            System.Console.WriteLine("Yes, "+ number +" is a palindrome number.");
            return true;
        } else
        {
            System.Console.WriteLine("No, "+ number +" is not a plindrome number.");
            return false;
        }
    }
}