public class Solution {
    public int MinSwaps(int[] nums) {
            int countNum1 = nums.Sum(),
            expected = int.MaxValue;
            if (countNum1 == 0) return 0;

            List<int> list = new List<int>();
            list.AddRange(nums);
            list.AddRange(nums);
            nums = list.ToArray();

            int count = 0,winStart = 0, winEnd = countNum1 - 1,OnceIndex = winStart;
            for (int i = 0; i <= winEnd; i++){
                if (nums[OnceIndex] == 0) count++;
                OnceIndex++;
            } expected = count;

            while (winEnd <= nums.Length) {
                if(nums[winStart] == 0)  count--;
                winStart++;
                if (winEnd < nums.Length - 1) winEnd++;
                else return expected;
                if (nums[winEnd] == 0) count++;
                expected = Math.Min(expected,count);
            }  return expected;    
    }
}