public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        // tách chuỗi theo từng từ
        string[] worlds = sentence.Split(' ');
        // lặp từ
        for(int world = 0; world < worlds.Length; world ++) { 
            // lấy giá trị đầu tiên
            if(worlds[world].StartsWith(searchWord)) {
                return world + 1;
            }
        }
        // ngược lại trả về -1
        return -1;
    }
}