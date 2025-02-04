public class Solution {
    public int CountSeniors(string[] details) {
            int count = 0;
            foreach (string i in details)
                if (int.Parse(i.Substring(11, 2)) > 60)  
                count++;
            return count;
    }
}