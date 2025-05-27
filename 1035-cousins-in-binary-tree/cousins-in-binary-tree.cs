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
    public TreeNode xParent = null;
    public TreeNode yParent = null;
    public int xDepth =  -1;
    public int yDepth = -1;
    public bool IsCousins(TreeNode root, int x, int y) {
        Traverse(root, null, 0, x, y);

        return xDepth == yDepth && xParent != yParent;
    }

    private void Traverse(TreeNode node, TreeNode parent, int l, int x, int y) {
        if(node == null) {
            return;
        }

        if(node.val == x) {
            xParent = parent;
            xDepth = l;
        }

        if(node.val == y) {
            yParent = parent;
            yDepth = l;
        }

        Traverse(node.left, node, l + 1, x, y);
        Traverse(node.right, node, l + 1, x, y);
    }
}