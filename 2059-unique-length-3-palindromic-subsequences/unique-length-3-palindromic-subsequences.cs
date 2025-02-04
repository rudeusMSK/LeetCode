public class Solution {
    public int CountPalindromicSubsequence(string s) {
      /*
        mình đã xem bài giải vì ko giải được bài này ! ít nhất cũng hiểu được cách để giải :3 .
*/
        // có 26 ký tự trong bản chữ cái nên độ dài của mảng là 26.
        int [] R = new int[26]; // đếm số lần xuất hiện của các ký tự từ trái sang.
        int [] L = new int[26]; // đánh dấu các ký tự đã được ghé thăm.
        int ans = 0;
        HashSet<int> S = new HashSet<int>();
        
        /*  B1: 
            đếm số lần các ký tự xuất hiện của các ký tự.
            có thể biết được vị trí của chúng thông qua: '<ký tự>' - 'a'.
            mỗi lần xuất hiện ta đánh dấu chúng bằng cách công thêm 1 đơn vị.
        */
        foreach (char c in s) {
            R[c - 'a']++;
        }

        /*  B2:
            duyệt mảng:
            lấy vị trí của chữ bằng '<ký tự>' - 'a'.
            mỗi lần duyệt qua 1 ký tự thì ký tự bên phải sẽ trừ đi một đơn vị vì ta đã duyệt qua ròi.
            ... điều kiện ...
            và thêm vào 1 đơn vị cho ký tự đó để đánh dấu là ta đã duyệt qua nó ròi.

            ... điều kiện ...

            lặp qua bảng chữ cái
            nếu chữ bên trái vài phải đã được đánh dấu thì thỏa điều kiện  

            ... điều kiện ...
        */

            foreach (char character in s) {
                int currentCharacter = character - 'a';
                R[currentCharacter]--;
                for(int index = 0; index < 26; index++) {
                    if(L[index] > 0 && R[index] > 0) S.Add(26 * currentCharacter + index); 
                } L[currentCharacter]++;
            }
            return S.Count;  
    }
}