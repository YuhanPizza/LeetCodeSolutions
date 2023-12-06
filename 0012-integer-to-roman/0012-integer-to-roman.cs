public class Solution {
    public string IntToRoman(int num) {
        int[] val = {1000,900,500,400,100,90,50,40,10,9,5,4,1};
        string[] rome={"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
         
        string outPut ="";
        int i =0;
        while(num > 0 && i < val.Length){
            if (num >= val[i])
            {
                outPut += rome[i];
                num -= val[i];
            }
            else
            {
                i++;
            }
        }
        return outPut;
    }
}