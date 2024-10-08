public class Solution
{
    public static int[] TwoSum(int[] nums, int target) //method that passes an array and asks for an array and an integer
    {
        for (int FirstIndex = 0; FirstIndex < nums.Length ; FirstIndex++)
        {
            for (int SecondIndex = FirstIndex + 1; SecondIndex < nums.Length; SecondIndex++)
            {
                if (nums[FirstIndex] + nums[SecondIndex] == target) 
                {
                    return new int[] {FirstIndex, SecondIndex};
                }
            }
        }
        return new int[] {};
    } 

    public static int RomantoInteger(string romanLetters)
    {
        var romanToInt = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        var LengthofString = romanLetters.Length; // lenght of the inputed string

        var sum = romanToInt[romanLetters[LengthofString - 1]]; // creating of variable sum and getting the last indice of the inputed string

        for (int i = LengthofString - 1; i > 0; i --)
        {
            if(romanToInt[romanLetters[i - 1]] >= romanToInt[romanLetters[i]])
            {
                sum += romanToInt[romanLetters[i - 1]];
            }else
            {
                sum -= romanToInt[romanLetters[i -1]];
            }
        }
        return sum;
    }

    public static bool PalindromeNumber(int number) {
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


    public static string LongestCommonPrefix(string[] strings)
    {
        if(strings == null || strings.Length == 0 )
        {
        return "";
        }


        string prefix = strings[0];

        for(int i = 1; i < strings.Length; i++) // starts with the second string in the array (i = 1) and checks if our current prefix is a prefix of each subsequent string
        {
            while(strings[i].IndexOf(prefix) !=0)    // This part checks if the current string strs[i] starts with the prefix.
                                                    // IndexOf(prefix) finds the position of prefix in the string. If prefix is at the start, 
                                                   // IndexOf returns 0. If it's not at the start, there is a mismatch.
            {
                prefix = prefix.Substring(0, prefix.Length - 1); // If there’s a mismatch, shorten the prefix by one character from the end using Substring.
                if (prefix == "") // if the prefix becomes an empty string, return ""
                return "";  
            }
        }
        return prefix;
    }
}