public class Solution {
    public int MinimumPushes(string word) {
            int i = 0;
            int expected = 0;
            Dictionary<string, int> charCount = new Dictionary<string, int>();
            List<string> charaters = word.Select(w => w.ToString()).ToList();

            while (charaters.Count > 0){
                string c = charaters[0];
                int count = charaters.Count(charater => charater == c);
                charCount[c] = count;
                charaters.RemoveAll(ch => ch == c);
            }
            List<Tuple<string, int>> sortedList = charCount
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => Tuple.Create(kvp.Key, kvp.Value)).ToList();

            foreach (var charater in sortedList){
                expected += charater.Item2 * (i / 8 + 1);
                i++;
            }
            return expected; 
    }
}