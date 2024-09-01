

int[] ArrayTest = { 2, 7, 11, 15 };
int TargetTest = 9;

// Call the TwoSumMethod from TwoSum class
int[] result = TwoSum.CheckTarget(ArrayTest, TargetTest); // static method

if (result.Length > 0)
{
    Console.WriteLine($"Indices: {result[0]}, {result[1]}");
}
else
{
    Console.WriteLine("No solution found.");
}

int PalindromeTest = 121;

PalindromeNumber.IsPalindrome(PalindromeTest);

string RomanTest = "III";
string RomanTest2 = "LVIII";
string RomanTest3 = "MCMXCIV";
int sum = RomantoInteger.ConvertRomanToInterger(RomanTest);
int sum2 = RomantoInteger.ConvertRomanToInterger(RomanTest2);
int sum3 = RomantoInteger.ConvertRomanToInterger(RomanTest3);
Console.WriteLine(sum);
Console.WriteLine(sum2);
Console.WriteLine(sum3);