public class Solution {
    public bool IsValid(string s) {
        char[] all = s.ToCharArray();
        int size = all.Length;
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < size; i++) {
            if (all[i] == '(' || all[i] == '{' || all[i] == '[') {
                stack.Push(all[i]);
            } else if (all[i] == ')' && (stack.Count == 0 || stack.Pop() != '(')) {
                return false;
            } else if (all[i] == '}' && (stack.Count == 0 || stack.Pop() != '{')) {
                return false;
            } else if (all[i] == ']' && (stack.Count == 0 || stack.Pop() != '[')) {
                return false;
            }
        }

        return stack.Count == 0;
    }
}