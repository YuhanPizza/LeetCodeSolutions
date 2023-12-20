public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i] += 1;
                return digits;
            } else {
                digits[i] = 0;
            }
        }

        // If we are here, it means we need to add a new digit (carry)
        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
}