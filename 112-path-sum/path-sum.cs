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
    public bool HasPathSum(TreeNode root, int targetSum) {
        return FindSum(root, targetSum);
    }

    private bool FindSum(TreeNode root, int target) {
        if(root == null) {
            return false;
        }

        if(root.left == null && root.right == null && target == root.val) {
            return true;
        }

        return FindSum(root.left, target - root.val) || FindSum(root.right, target - root.val);
    }
}