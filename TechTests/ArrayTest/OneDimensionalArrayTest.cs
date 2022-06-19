using TechExercises.Array;

namespace TechTests.ArrayTest
{
    public class OneDimensionalArrayTest
    {
        [Fact]
        public void ContainsDuplicateTest()
        {
            OneDimensionalArray testSubArray = new OneDimensionalArray();
            int[] input = new[] { 1,2,3,1};
            bool result = testSubArray.ContainsDuplicate(input);
            Assert.True(result);
        }
    }
}