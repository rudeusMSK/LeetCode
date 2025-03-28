public class Solution {
    public int RomanToInt(string s) {
        var map = new Dictionary<string,int>() {
            { "I", 1 }, 
            { "V", 5 },
            { "X", 10},
            { "L", 50},
            { "C", 100},
            { "D", 500},
            { "M", 1000},
            { "IV", 4}, 
            { "IX", 9}, 
            { "XL", 40}, 
            { "XC", 90}, 
            { "CD", 400}, 
            { "CM", 900}, 
        };

        var sum = 0;
        var i = 0;

        while(i < s.Length){
            if(i < s.Length -1 && map[s[i].ToString()] <  map[s[i+1].ToString()])
            {
                var t = $"{s[i]}{s[i+1]}";
                sum += map[t]; 
                i += 2;
            } else {
                sum += map[s[i].ToString()];
                i += 1;
            }
        }

        return sum;
    }
}