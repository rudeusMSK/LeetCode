public class NumberContainers {

    //  mình đã xem lời giải để chỉnh sửa những logic thiếu sót làm cho kết quả sai.

    private Dictionary<int, int> numberContainer;
    private Dictionary<int,SortedSet<int>> uniqueNumber;

    public NumberContainers() {
        numberContainer = new Dictionary<int, int>();
        uniqueNumber = new Dictionary<int,SortedSet<int>>();
    }
    
    public void Change(int index, int number) {
        if (numberContainer.ContainsKey(index)) {
            int oldNumber = numberContainer[index];

            // Xóa index cũ khỏi uniqueNumber[oldNumber]
            if (uniqueNumber.ContainsKey(oldNumber)) {
                uniqueNumber[oldNumber].Remove(index);
                // Xóa key nếu không còn index nào
                if (uniqueNumber[oldNumber].Count == 0) {
                    uniqueNumber.Remove(oldNumber); 
                }
            }
        }
        // Cập nhật numberContainer với số mới
        numberContainer[index] = number;

        // Thêm index vào uniqueNumber[number]
        if (!uniqueNumber.ContainsKey(number)) {
            uniqueNumber[number] = new SortedSet<int>();
        }
        uniqueNumber[number].Add(index);
    }
    
    public int Find(int number) {
     // Nếu number không tồn tại hoặc không có index nào lưu nó, trả về -1
        return uniqueNumber.ContainsKey(number) && uniqueNumber[number].Count > 0 
            ? uniqueNumber[number].First() 
            : -1;
    }
}

/**
 * Your NumberContainers object will be instantiated and called as such:
 * NumberContainers obj = new NumberContainers();
 * obj.Change(index,number);
 * int param_2 = obj.Find(number);
 */