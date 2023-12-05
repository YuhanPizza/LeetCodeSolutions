public class Solution {
    public bool IsPalindrome(int x) {
        string potato = x.ToString();
        int curr = potato.Length - 1;
        for (int i = 0; i < potato.Length; i++){
            if (potato[i] != potato[curr]){
                return false;
            }
            curr--;
        }
        return true;
    }
}
