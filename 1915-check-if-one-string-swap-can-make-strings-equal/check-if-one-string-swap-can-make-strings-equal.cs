public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
    // mình đã xem lời giải vì kẹt ở testcase thứ 104 :3

    // các chuỗi điều là chữ thường.    
    s1.ToLower(); 
    s1.ToLower(); 

    // nếu chuỗi đã giống nhau ko cần làm gì.
    if (s1 == s2 )
            return true;

    // tạo mảng chứa danh sách các chữ:
     char[] s1Arr = s1.ToCharArray();
     char[] s2Arr = s2.ToCharArray();
    
    // lấy chiều dài mảng
     int s1Size = s1Arr.Length;

     // danh sách chứa vị trí các ký tự khác nhau.
     List<int> differentIndex = new List<int>();
     
    // kiểm tra có hơn 2 ký tự để thực hiện hoán đổi hay không. 
    if (s1Size <= 1) return false;
    else {
        // kiểm tra vị trí khác nhau để đưa vào danh sách.
        for (int i = 0; i < s1Size; i++ ) {
        if(s1Arr[i] != s2Arr[i]) differentIndex.Add(i);
        }

        // nếu có 2 sự thay đổi thì kiểm tra, nếu nhiều hay ít hơn tức là đã nhiều hơn 1 lần swap hoặc ko có.
        if (differentIndex.Count == 2){
            // lấy vị trí thứ 1 và 2
             int first = differentIndex[0], 
             second = differentIndex[1];
            // kiểm tra kết quả hoán đổi s1 thứ nhất có bằng s2 thứ hai không và ngược lại.
            return s1Arr[first] == s2Arr[second] && s1Arr[second] == s2Arr[first];
        }
        return false;
    }
    }
}