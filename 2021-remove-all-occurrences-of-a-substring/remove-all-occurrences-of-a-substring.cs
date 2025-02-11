public class Solution {
    public string RemoveOccurrences(string s, string part) {
        int index;
        int size = part.Length;
        // culture-sensitive comparison:
        // while ((index = s.IndexOf(part)) != -1) {
        //     s = s[0..index] + s[(index + size)..];
        // }
        //

        // Ordinal bỏ qua so sánh văn hóa như ký tự đặc biệt, chữ hoa, chữ thường...
        while ((index = s.IndexOf(part,StringComparison.Ordinal)) != -1) {
            s = s[0..index] + s[(index + size)..];
        }   
        return s;
    }
}