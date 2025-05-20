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
    private bool balanced = true;
    public bool IsBalanced(TreeNode root) {
        GetHeight(root);

        return balanced;
    }

    private int GetHeight(TreeNode node) {
        if(node == null) {
            return 0;
        }

        var left = GetHeight(node.left);
        var right = GetHeight(node.right);

        if(Math.Abs(left - right) >= 2) {
            balanced = false;
        }

        return Math.Max(left, right) + 1;
    }
}