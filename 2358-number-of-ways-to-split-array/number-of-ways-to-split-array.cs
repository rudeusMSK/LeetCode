public class Solution {
    public int WaysToSplitArray(int[] nums) {

        /* khai báo tổng của vế trái và vế phải. */
        int ans = 0; // lưu kq

        //  | tổng mảng |    | tổng vế trái |      | tổng vế phải |
        long totalNums = 0, leftSplitNumber = 0, rightSplitNumber = 0;
        
        // đếm tổng của mảng nums.
        // foreach (int num in nums) { //        <== best choice
        //     totalNums += num;
        // }

        Array.ForEach(nums, delegate(int i) { totalNums += i; });

        // lặp qua các phần tử của mảng với chiều dài của mảng -1 để cả hai vế ko rỗng.
        for (int i = 0; i < nums.Length - 1; i++) {
        // tính tổng | vế phải| ---------------- | vế trái |
        rightSplitNumber = totalNums - (leftSplitNumber += nums[i]);

        // kq: (tổng trừ đi vế trái)
        if (leftSplitNumber >= rightSplitNumber) 
        ans++;
    }
        // trả về kết quả.
        return ans;
    }
}