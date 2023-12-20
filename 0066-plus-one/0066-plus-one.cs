public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> result = new List<int>();
        
        int carry = 1;
        
        for(int i = digits.Length - 1; i >=0; i--){
            int sum = digits[i] + carry;
            result.Insert(0, sum % 10);
            carry = sum / 10;
        }
        
        if(carry > 0 ){
            result.Insert(0, carry);
        }
        return result.ToArray();
    }
}