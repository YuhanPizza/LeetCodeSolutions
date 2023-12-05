public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] potato = new int [2];
        for(int i = 0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    potato[0] = i;
                    potato[1] = j;
                    return potato;
                }
            }
        }
        return potato;
    }
}