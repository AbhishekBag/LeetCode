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
    private int maxDiameter = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        GetDiameter(root);

        return maxDiameter;
    }

    private int GetDiameter(TreeNode root) {
        if(root == null) {
            return 0;
        }

        int left = GetDiameter(root.left);
        int right = GetDiameter(root.right);
        maxDiameter = Math.Max(maxDiameter, left + right);

        return Math.Max(left, right) + 1;
    }
}