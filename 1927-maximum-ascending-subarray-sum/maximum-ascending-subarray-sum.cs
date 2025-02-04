public class Solution {
    public int MaxAscendingSum(int[] nums) {
            List<int> SubArray = new List<int>();
            int totalNum = nums[0];
            for (int i = 1; i < nums.Length; i++) {
                 if (nums[i] > nums[i - 1]) totalNum += nums[i];
                 else {
                    SubArray.Add(totalNum);
                    totalNum = nums[i];
                }
                SubArray.Add(totalNum);
            }
            // 
            return !SubArray.Any() ? totalNum : SubArray.Max();
    }
}