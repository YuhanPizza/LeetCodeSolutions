/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();
        if(root == null) return result;
        Stack<TreeNode> potato = new Stack<TreeNode>();
        TreeNode curr = root;
        while(curr != null || potato.Count() != 0){
            while(curr !=null){
                potato.Push(curr);
                curr = curr.left;
            }
            curr = potato.Pop();
            result.Add(curr.val);
            curr = curr.right;
        }
        return result;
    }
}