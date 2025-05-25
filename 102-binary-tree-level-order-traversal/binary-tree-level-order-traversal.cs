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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> res = new();
        Queue<Node> q = new();

        if(root == null) {
            return res;
        }

        res.Add(new List<int> { root.val });
        var prev = new Node(root, 0);
        if(root.left != null) {
            q.Enqueue(new Node(root.left, 1));
        }

        if(root.right != null) {
            q.Enqueue(new Node (root.right, 1));
        }
        while(q.Count > 0) {
            var cur = q.Dequeue();
            if(cur.level == prev.level) {
                res[res.Count - 1].Add(cur.node.val);
            } else {
                res.Add(new List<int> { cur.node.val });
            }

            if(cur.node.left != null) {
                q.Enqueue(new Node(cur.node.left, cur.level + 1));
            }

            if(cur.node.right != null) {
                q.Enqueue(new Node (cur.node.right, cur.level + 1));
            }

            prev = cur;
        }

        return res;
    }
}

partial class Node {
    public TreeNode node;
    public int level;

    public Node(TreeNode t, int l) {
        node = t;
        level = l;
    }
}