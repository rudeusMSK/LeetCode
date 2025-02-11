public class Solution {
    public string RemoveOccurrences(string s, string part) {
        int index;
        int size = part.Length;
        while ((index = s.IndexOf(part)) != -1) {
            s = s[0..index] + s[(index + size)..];
        }  return s;
    }
}