public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
            return "";

        string prefix = strs[0]; // Birinchi stringdan boshlaymiz

        for (int i = 1; i < strs.Length; i++)
        {
            // prefixni hozirgi string bilan solishtirib umumiy qismini olamiz
            while (!strs[i].StartsWith(prefix))
            {
                // Har safar oxirgi harfni kesib tashlaymiz
                prefix = prefix.Substring(0, prefix.Length - 1);

                // Agar bo‘sh bo‘lib qolsa, umumiy prefiks yo‘q
                if (prefix == "")
                    return "";
            }
        }

        return prefix;
    }
}