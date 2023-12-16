public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        char[] one = s.ToCharArray();
        char[] two = t.ToCharArray();
        
        Array.Sort(one);
        Array.Sort(two);
        
        for(int i = 0; i < s.Length; i++){
            if(one[i] != two[i]){
                return false;
            }
        }
        return true;
    }
}