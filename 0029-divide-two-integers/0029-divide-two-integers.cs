public class Solution {
    public int Divide(int dividend, int divisor) {
        long value1 = (long)dividend;
        long value2 = (long)divisor;

        long result = value1/value2;

        return (result > int.MaxValue) ? int.MaxValue : (int)result;
    }
}