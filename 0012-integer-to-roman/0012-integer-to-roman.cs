public class Solution {
    public string IntToRoman(int num) {
        int[] val = {1000,900,500,400,100,90,50,40,10,9,5,4,1};
        string[] rome={"M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
        
        if(num > 0){
            for (int j =0; j < val.Length; j++){
                if(val[j] <= num){
                    num -= val[j];
                    return rome[j] += IntToRoman(num);
                }  
            }
        }
        return "";
    }
}