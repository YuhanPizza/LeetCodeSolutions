public class Solution {
 //   public int LengthOfLastWord(string s) {
 //      string[] stapoopt = s.Split();
 //       for(int i = stapoopt.Length - 1; i >= 0; i--){
 //           if(stapoopt[i].Length > 0){
 //              return stapoopt[i].Length;
 //           }
 //       }
 //       return stapoopt.Length;
 //   }
    public int LengthOfLastWord(string s) => s.Trim().Split().Last().Length;
}