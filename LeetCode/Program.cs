int[] nums = { 2, 7, 11, 15 };
int target = 9;

// Call the TwoSumMethod from TwoSum class
int[] result = Solution.TwoSum(nums, target);

if (result.Length > 0)
{
    Console.WriteLine($"Indices: {result[0]}, {result[1]}");
}
else
{
    Console.WriteLine("No solution found.");
}
