public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) return "";
        Array.Sort(strs);
        string first = strs[0], last = strs[strs.Length - 1];
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < first.Length; i++) {
            if (i < last.Length && first[i] == last[i]) {
                result.Append(first[i]);
            } else {
                break;
            }
        }
        return result.ToString();
    }
}