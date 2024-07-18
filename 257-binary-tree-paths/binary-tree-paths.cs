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
    private HashSet<string> master = new HashSet<string>();
    public IList<string> BinaryTreePaths(TreeNode root) {
        List<string> res = new List<string>();

        Traverse(root, new List<int>());

        return master.ToList();
    }

    private void Traverse(TreeNode root, List<int> current) {
        if(root == null) {            
            return;
        }

        current.Add(root.val);
        if(root.left == null && root.right == null && current.Count > 0) {
            master.Add(string.Join("->", current.ToList()));
        }

        Traverse(root.left, current);
        Traverse(root.right, current);

        current.RemoveAt(current.Count() - 1);
    }
}