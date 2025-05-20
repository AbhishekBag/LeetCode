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
    private int diameter;
    public int DiameterOfBinaryTree(TreeNode root) {
        GetDiameter(root);

        return diameter;
    }

    private int GetDiameter(TreeNode node) {
        if(node == null) {
            return 0;
        }

        var left = GetDiameter(node.left);
        var right = GetDiameter(node.right);

        diameter = Math.Max(diameter, left + right);

        return Math.Max(left, right) + 1;
    }
}