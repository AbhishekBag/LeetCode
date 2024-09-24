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
    private int maxSum = 0;
    public int MaxPathSum(TreeNode root) {
        maxSum = root.val;
        GetPathSum(root);

        return maxSum;
    }

    private int GetPathSum(TreeNode node) {
        if(node == null) {
            return 0;
        }

        int left = Math.Max(0, GetPathSum(node.left));
        int right = Math.Max(0, GetPathSum(node.right));

        maxSum = Math.Max(maxSum, left + node.val + right);

        return Math.Max(left, right) + node.val;
    }
}