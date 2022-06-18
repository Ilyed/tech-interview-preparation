namespace TechExercices.Array;

public class Subarray
{
    //LeetCode 53. Maximum Subarray
    public int MaxSubArray(int[] nums)
    {
        int[] table = new int[nums.Length];
        int maxSum = nums[0];
        table[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            table[i] = Math.Max(nums[i], nums[i] + table[i - 1]);
            maxSum = Math.Max(maxSum, table[i]);
        }

        return maxSum;
    }
}