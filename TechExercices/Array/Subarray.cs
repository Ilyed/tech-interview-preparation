namespace TechExercices.Array;

public class Subarray
{
    //LeetCode 53. Maximum Subarray
    public int MaxSubArray(int[] nums)
    {
        int maxSum = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            int currentMax = 0;
            for (int j = i; j < nums.Length; j++)
            {
                currentMax += nums[j];
            }

            if (currentMax >= maxSum)
            {
                maxSum = currentMax;
            }
        }
        return maxSum;
    }
}
