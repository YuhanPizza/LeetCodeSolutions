public class Solution {
    public int MySqrt(int x) {
        if(x == 0 || x == 1){
            return x;
        }
        long start = 1, end = x / 2, result = 0;
        while(start <= end){
            long mid = (start + end ) /2;
            if(mid * mid == x ){
                return (int)mid;
            }
            if(mid * mid < x){
                start = mid + 1;
                result = mid;
            }
            else{
                end = mid - 1;
            }
        }
        return (int)result;
    }
}