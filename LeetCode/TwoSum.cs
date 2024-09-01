public class TwoSum
{
    public static int[] CheckTarget(int[] nums, int target) //method that passes an array and asks for an array and an integer
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
}