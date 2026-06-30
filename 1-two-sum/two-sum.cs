public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int kalan;
        for (int i = 0; i < nums.Length; i++)
        {
        kalan = target - nums[i];
        for (int j = i+1; j< (nums.Length); j++)
        {
         if(nums[i] + nums[j] == target){
return new int[] {i,j};
         }
        }

        }
        return new int[] {};
    }
}