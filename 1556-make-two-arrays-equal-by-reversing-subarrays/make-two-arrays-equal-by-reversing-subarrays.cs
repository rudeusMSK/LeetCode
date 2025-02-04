public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
            List<int> arrlist = new List<int>();
            arrlist.AddRange(arr);
            List<int> targetlist = new List<int>();
            targetlist.AddRange(target);

            for (int i = 0;i < arrlist.Count ; i++) {
                int findarr = arrlist.Where(j => j == target[i]).Count();
                int findtarget = targetlist.Where(j => j == target[i]).Count();

                if (findarr != findtarget)
                {
                    return false;
                }


                // ko tìm thấy
                if (findarr == 0) return false;
            }
            return true;
    }
}