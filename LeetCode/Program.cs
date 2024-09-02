

int[] ArrayTest = { 2, 7, 11, 15 };
int TargetTest = 9;

// Call the TwoSumMethod from TwoSum class
int[] result = Solution.TwoSum(ArrayTest, TargetTest); // static method

if (result.Length > 0)
{
    Console.WriteLine($"Indices: {result[0]}, {result[1]}");
}
else
{
    Console.WriteLine("No solution found.");
}

int PalindromeTest = 121;

Solution.PalindromeNumber(PalindromeTest);

string RomanTest = "III";
string RomanTest2 = "LVIII";
string RomanTest3 = "MCMXCIV";
int sum = Solution.RomantoInteger(RomanTest);
int sum2 = Solution.RomantoInteger(RomanTest2);
int sum3 = Solution.RomantoInteger(RomanTest3);
Console.WriteLine(sum);
Console.WriteLine(sum2);
Console.WriteLine(sum3);