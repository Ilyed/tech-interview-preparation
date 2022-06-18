using TechExercices.Array;

namespace TechTests.ArrayTest;

public class SubarrayTest
{
    [Fact]
    public void MaxSubArrayTest()
    {
        Subarray testSubArray = new Subarray();
        int[] input = new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int result = testSubArray.MaxSubArray(input);
        Assert.Equal(6,result);
    }
}