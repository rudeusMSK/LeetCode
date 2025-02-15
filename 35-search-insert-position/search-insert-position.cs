public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int ans;
        if((ans = Array.IndexOf(nums, target)) != -1){
         return ans;
        }

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > target){
                return i;
            }
        }
    return nums.Length;
    }
}