namespace TechExercises.Array
{
    public class OneDimensionalArrayBis
    {
        //Leetcode 217-bis
        public bool ContainsDuplicate(int[] nums)
        {
            var hashSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(nums[i])) return true;
                else
                {
                    hashSet.Add(nums[i]);
                }
            }

            return false;
        }

        //Leetcode 727
        public int RemoveDuplicates(int[] nums)
        {
            int numberOfElements = 0;
            int index = 0;
            var hashSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(nums[i])!)
                {
                    hashSet.Add(nums[i]);
                    nums[index] = nums[i];
                    index++;
                    numberOfElements++;
                }
            }
            return numberOfElements;
        }
    }
}