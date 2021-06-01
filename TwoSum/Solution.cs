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
