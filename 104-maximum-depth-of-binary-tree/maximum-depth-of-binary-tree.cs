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
    public int MaxDepth(TreeNode root) {
        return GetDepth(root);
    }

    private int GetDepth(TreeNode root) {
        if(root == null) {
            return 0;
        }

        int left = GetDepth(root.left);
        int right = GetDepth(root.right);

        return Math.Max(left, right) + 1;
    }
}