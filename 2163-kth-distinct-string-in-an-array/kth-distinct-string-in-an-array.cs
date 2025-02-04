public class Solution {
    public string KthDistinct(string[] arr, int k) {
        // chạy deadline cho kịp ngày nên ko quan tâm hiệu năng !
            List<string> list = new List<string>();
            list.Add("");
            list.AddRange(arr);
            string[] ans = new string[list.Count];
            for (int item = 1; item < list.Count; item++) {
                int count = list.Count(i => i == list[item]);
                if (count > 1) {
                    string RemoveItem = list[item];
                    list.RemoveAll(i => i == RemoveItem);
                    if (list.Count == 1) return "";
                    item = 0; // :)) đoạn code ngu ngốc nhất của tôi !
                    }
            }
            ans = list.ToArray();
            if (k> ans.Length) return "";
            return ans[k] == null ? "" : ans[k];
    }
}