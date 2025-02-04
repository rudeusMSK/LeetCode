public class Solution {
    public int MaxScore(string s) {
            // setup:
    int totalZeros = 0, // tổng số '0' trong chuỗi.
    //  Tổng số '0' vế trái.
    L = 0,
    // tổng vế phải.
    R = 0, 
    // kết quả.
    ans = -1,
    // chiều dài chuỗi.
    s_Length = s.Length;
    
    // B1: tính tổng số '0' trong chuỗi.
    foreach (char charater in s){
        if(charater == '0') totalZeros++;
    }

    // B2: lặp chuỗi và chia 2 vế trái, phải.
    for (int i = 1; i < s_Length; i++){
        // => vế trái:
        if (s[i-1] == '0'){ 
            L++; 
            totalZeros--;
        }
        
        // => vế phải:
        R = s_Length - totalZeros - i;
        
        // B3: tính tổng kết quả hai vế:
        ans = Math.Max(ans, L + R );
    }
    // B4: lấy kết quả lớn nhất.
    return ans;
    }
}