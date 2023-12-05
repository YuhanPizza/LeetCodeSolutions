public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length <= 0){
            return "";
        }
        int minLength = strs.Min(s => s.Length);
        StringBuilder potato = new StringBuilder();
        
        for(int i =0; i < minLength; i++){
            char currentChar = strs[0][i];
            if(strs.All(s => s[i] == currentChar)){
                potato.Append(currentChar);
            }else{
                break;
            }
        }
        return potato.ToString();
    }
}