public class Solution {
    public static int[] TwoSum(int[] nums, int target) {
        for (int FirstIndex = 0; FirstIndex < nums.Length; FirstIndex++)
        {
            for (int SecondIndex = FirstIndex + 1; SecondIndex < nums.Length; SecondIndex++)
            {
                if (nums[FirstIndex]+nums[SecondIndex] == target)
                {
                    return new int[] {FirstIndex, SecondIndex};
                }
            }
        }
        return new int[] {};
    }
}