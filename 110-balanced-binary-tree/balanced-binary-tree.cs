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
    public bool IsBalanced(TreeNode root) {
        if(root == null) {
            return true;
        }

        bool isRootBalanced = Math.Abs(GetDepth(root.left) - GetDepth(root.right)) <= 1;

        return isRootBalanced && IsBalanced(root.left) && IsBalanced(root.right);
    }

    private int GetDepth(TreeNode root) {
        if(root == null) {
            return 0;
        }

        return Math.Max(GetDepth(root.left), GetDepth(root.right)) + 1;
    }
}