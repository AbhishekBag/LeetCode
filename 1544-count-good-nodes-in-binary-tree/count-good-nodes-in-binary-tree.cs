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
    private int count = 0;
    public int GoodNodes(TreeNode root) {
        if(root == null) {
            return 0;
        }

        CountGoodNode(root, Int32.MinValue);

        return count;
    }

    private void CountGoodNode(TreeNode node, int max) {
        if(node == null) {
            return;
        }

        if(node.val >= max) {
            count++;
        }

        max = Math.Max(max, node.val);

        CountGoodNode(node.left, max);
        CountGoodNode(node.right, max);
    }
}