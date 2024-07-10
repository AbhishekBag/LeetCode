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
    public int KthSmallest(TreeNode root, int k) {
        List<int> items = new List<int>();
        VisitBST(root, items, k);

        return items[k - 1];
    }

    private void VisitBST(TreeNode root, List<int> items, int k) {
        if(root == null || items.Count == k) {
            return;
        }

        VisitBST(root.left, items, k);
        items.Add(root.val);
        VisitBST(root.right, items, k);
    }
}