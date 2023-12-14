public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int cur = 0;
        for (int i = 0; i < nums.Length; i++){
            if (nums[i] == target){
                return i;
            }else if(target > nums[i]){
                cur = i + 1;
            }
        }
        return cur;
    }
}