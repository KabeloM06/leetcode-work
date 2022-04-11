public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        
        int prev = nums[0];
        int currentIndex = 0;
        
        
            for (var i = 1; i < nums.Length; i++)
            {
                if (prev != nums[i])
                {
                    currentIndex++;
                    nums[currentIndex] = nums[i];
                    prev = nums[i];
                }
            }

            return currentIndex + 1;
    }
}