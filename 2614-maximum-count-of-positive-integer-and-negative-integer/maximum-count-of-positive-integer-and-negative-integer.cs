public class Solution {
    public int MaximumCount(int[] nums) {
        int pos = 0;
        int neg = 0;

    // duyet mang
    foreach (int num in nums) {
    // kiem tra xem co bao nhieu so khac khong
        if(num == 0) continue;
        if(num < 0) pos++;
        else neg++;
    }
    return pos >= neg ? pos : neg;
    }
}