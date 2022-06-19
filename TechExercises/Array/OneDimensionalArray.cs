namespace TechExercises.Array
{
    public class OneDimensionalArray
    {
        //Leetcode 217
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    numbers.Add(nums[i]);
                }
            }
        
            return false;
        } 
    }
}