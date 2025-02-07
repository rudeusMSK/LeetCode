public class Solution {
    public int[] QueryResults(int limit, int[][] queries) {    
        /*      Setup:       */
        
        int balls = queries.Length;
        // The list of [balls, colors] was queried
        Dictionary<int, int> inventory = new Dictionary<int, int>();
        // unique colors:
        HashSet<int> uniqueColors = new HashSet<int>();
        // ans:
        int[] ans = new int[balls];

        /*      Query balls and colors       */
        
        for (int ball = 0; ball < balls; ball++) {
            
            int newKey = queries[ball][0];
            int newValue = queries[ball][1];

            if (inventory.ContainsKey(newKey)) {
                // update color ball:
                int oldValue = inventory[newKey];
                inventory[newKey] = newValue;

                // Delete old color in uniqueColors
                if (!inventory.ContainsValue(oldValue)) 
                uniqueColors.Remove(oldValue);
                
            } else {
                // Add new inventory:
                inventory.Add(newKey, newValue);
            }

            // Add new color:
            uniqueColors.Add(newValue);

            // Add unique color:
            ans[ball] = uniqueColors.Count;
        }
        return ans;
    }
}