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
        return ValidateBST(root, null, null);
    }

    public bool ValidateBST(TreeNode root, TreeNode min, TreeNode max) {
        if(root == null) {
            return true;
        }

        if(min != null && min.val >= root.val) {
            return false;
        }
        if(max != null && max.val <= root.val) {
            return false;
        }

        return ValidateBST(root.left, min, root) && ValidateBST(root.right, root, max);
    }
}