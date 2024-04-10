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
    private int max = 0;
    public int MaxPathSum(TreeNode root) {
        max = root.val;
        TravarseDFS(root);

        return max;
    }

    private int TravarseDFS(TreeNode node) {
        if(node == null) {
            return 0;
        }

        int leftPathSum = Math.Max(0, TravarseDFS(node.left));
        int rightPathSum = Math.Max(0, TravarseDFS(node.right));

        max = Math.Max(max, node.val + leftPathSum + rightPathSum);

        return node.val + Math.Max(leftPathSum, rightPathSum);
    }
}