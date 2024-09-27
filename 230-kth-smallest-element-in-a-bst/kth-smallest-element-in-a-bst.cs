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
    private int kMin = 0;
    private List<int> res;
    public int KthSmallest(TreeNode root, int k) {
        res = new List<int>();
        FindKSmall(root, k);

        return res[k - 1];
    }

    private void FindKSmall(TreeNode node, int k) {
        if(node == null || res.Count == k) {
            return;
        }

        FindKSmall(node.left, k);
        res.Add(node.val);
        FindKSmall(node.right, k);
    }
}