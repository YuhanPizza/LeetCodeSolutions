public class Solution {
    public int FirstUniqChar(string s) {
        for(int i = 0; i < s.Length; i++){
            for(int j = 0; j < s.Length; j++){
                if(s[i] == s[j] && i != j){
                    break;
                }
                if( j == s.Length - 1){
                    return i;
                }
            }
        }
        return -1;
    }
}