public class Solution {
    public bool IsPalindrome(int x) {
        string pali = x.ToString();
        int comp = pali.Length - 1;
        for(int i = 0; i < pali.Length; i++){
            if(pali[i] != pali[comp] ){
                return false;
            }
            comp--;
        }
        return true;
    }
}