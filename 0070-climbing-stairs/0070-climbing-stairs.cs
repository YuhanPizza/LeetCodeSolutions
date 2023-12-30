public class Solution {
    public int ClimbStairs(int n) {
        int n1 = 2; //n - 2
        int n2 = 1; // n - 1
        
        if(n <= 1) return 1; //if value of n is 0 or 1 it will only take 1 step regardless.
        
        for (int i = 3; i <= n; i++){ // it will iterate through all steps possible for n 
            int ni = n1 + n2; //ni starts at 3 cuz 3 = 3; at i =4 ni = 5; at i =5 ni = 8;
            n2 = n1; // n2 = 2; n2 = 3; n2 = 5
            n1 = ni; //n1 = 3; n1 = 5; n1 = 8
        }
        
        return n1;
    }
}