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
    public bool IsValidBST(TreeNode root) {
        return ValidBST(root, null, null);
    }

    private bool ValidBST(TreeNode node, TreeNode min, TreeNode max) {
        if(node == null) {
            return true;
        }

        if(min != null && node.val >= min.val) {
            return false;
        }

        if(max != null && node.val <= max.val) {
            return false;
        }

        return ValidBST(node.left, node, max) && ValidBST(node.right, min, node);
    }
}