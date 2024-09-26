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
    private int max;
    public int MaxPathSum(TreeNode root) {
        if(root == null) {
            return 0;
        }

        max = root.val;
        FindMaxSum(root);

        return max;
    }

    private int FindMaxSum(TreeNode node) {
        if(node == null) {
            return 0;
        }

        int leftSum = Math.Max(0, FindMaxSum(node.left));
        int rightSum = Math.Max(0, FindMaxSum(node.right));

        max = Math.Max(max, leftSum + rightSum + node.val);
        return Math.Max(leftSum, rightSum) + node.val;
    }
}