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
    public TreeNode InvertTree(TreeNode root) {
        InvertNode(root);

        return root;
    }

    private void InvertNode(TreeNode root) {
        if(root == null) {
            return;
        }

        InvertNode(root.left);
        InvertNode(root.right);

        var tmp = root.left;
        root.left = root.right;
        root.right = tmp;
    }
}