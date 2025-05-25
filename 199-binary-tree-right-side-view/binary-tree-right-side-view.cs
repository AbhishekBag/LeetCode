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
    private List<int> res = new ();
    public IList<int> RightSideView(TreeNode root) {
        GetRightView(root, 0);

        return res;
    }

    private void GetRightView(TreeNode node, int level) {
        if(node == null) {
            return;
        }

        if(res.Count <= level) {
            res.Add(node.val);
        } else {
            res[level] = node.val;
        }

        GetRightView(node.left, level + 1);
        GetRightView(node.right, level + 1);
    }
}