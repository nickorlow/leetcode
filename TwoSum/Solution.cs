/*
Runtime: 228 ms, faster than 97.86% of C# online submissions for Median of Two Sorted Arrays.
Memory Usage: 32.2 MB, less than 31.14% of C# online submissions for Median of Two Sorted Arrays.
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i<nums.Length; i++){
            for(int y = i; y<nums.Length; y++){    
                if(y!=i && nums[i]+nums[y]==target)
                    return new int[]{i, y};
            }
        }
        return new int[] {-1};
    }
}
