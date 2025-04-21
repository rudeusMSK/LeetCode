public class Solution {
    public int CountPairs(int[] nums, int k) {
        int cnt = 0, n = nums.Length;
        for(int i = 0; i < n; i++)
            for(int j = i + 1; j < n; j++){
                int multi = i * j;
                if(nums[i] == nums[j] && multi % k == 0) cnt++;
            }   return cnt;
    }
}