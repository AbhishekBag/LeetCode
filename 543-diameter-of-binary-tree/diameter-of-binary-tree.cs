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
    public int DiameterOfBinaryTree(TreeNode root) {
        GetDiameter(root);

        return max;
    }

    private int GetDiameter(TreeNode root) {
        if(root == null) {
            return 0;
        }

        int leftDepth = GetDiameter(root.left);
        int rightDepth = GetDiameter(root.right);

        max = Math.Max(max, leftDepth + rightDepth);

        return Math.Max(leftDepth, rightDepth) + 1;
    }
}