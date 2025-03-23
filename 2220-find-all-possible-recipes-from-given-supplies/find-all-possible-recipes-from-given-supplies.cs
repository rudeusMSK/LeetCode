public class Solution {
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies)
    {
        // Tạo mapping: recipe -> list các nguyên liệu cần thiết
        Dictionary<string, IList<string>> recipeMap = new Dictionary<string, IList<string>>();
        for (int i = 0; i < recipes.Length; i++)
        {
            recipeMap[recipes[i]] = ingredients[i];
        }

        // Sử dụng HashSet cho supplies để kiểm tra nhanh
        HashSet<string> supplySet = new HashSet<string>(supplies);
        // Memo hóa kết quả cho mỗi recipe
        Dictionary<string, bool> memo = new Dictionary<string, bool>();
        List<string> result = new List<string>();

        foreach (var recipe in recipes)
        {
            if (CanMake(recipe, recipeMap, supplySet, memo, new HashSet<string>()))
            {
                result.Add(recipe);
            }
        }
        return result;
    }

    public bool CanMake(
        string recipe,
        Dictionary<string, IList<string>> recipeMap,
        HashSet<string> supplySet,
        Dictionary<string, bool> memo,
        HashSet<string> visiting)
    {
        // Nếu đã có trong supplies thì có thể tạo ra
        if (supplySet.Contains(recipe))
            return true;

        // Nếu recipe không có trong mapping tức không có cách nào để tạo ra nó
        if (!recipeMap.ContainsKey(recipe))
            return false;

        // Nếu đã tính toán, trả về kết quả memo
        if (memo.ContainsKey(recipe))
            return memo[recipe];

        // Kiểm tra chu trình
        if (visiting.Contains(recipe))
            return false;

        visiting.Add(recipe);
        foreach (var ing in recipeMap[recipe])
        {
            // Nếu nguyên liệu không có trong supplies và không thể tạo ra thì trả về false
            if (!supplySet.Contains(ing) && !CanMake(ing, recipeMap, supplySet, memo, visiting))
            {
                memo[recipe] = false;
                visiting.Remove(recipe);
                return false;
            }
        }
        visiting.Remove(recipe);

        // Sau khi kiểm tra tất cả, đánh dấu rằng recipe có thể tạo được
        memo[recipe] = true;
        // Thêm recipe vào supplies để dùng cho các recipe khác
        supplySet.Add(recipe);
        return true;
    }
}