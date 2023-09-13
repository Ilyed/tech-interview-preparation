namespace TechExercises.Array
{
    public static class OneDimensionalArrayBis
    {
        //Leetcode 217-bis
        public static bool ContainsDuplicate(int[] nums)
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
        public static int RemoveDuplicates(int[] nums)
        {
            int numberOfElements = 0;
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
    }
}