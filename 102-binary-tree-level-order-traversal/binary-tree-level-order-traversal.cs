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
        List<IList<int>> res = new List<IList<int>>();
        if(root == null) {
            return res;
        }

        Queue<Node> q = new Queue<Node>();
        q.Enqueue(new Node(root, 0));

        var prev = q.Dequeue();
        res.Add(new List<int>() {prev.node.val});

        if(prev.node.left != null) {
            q.Enqueue(new Node(prev.node.left, prev.level + 1));
        }

        if(prev.node.right != null) {
            q.Enqueue(new Node(prev.node.right, prev.level + 1));
        }

        while(q.Count() > 0) {
            var poped = q.Dequeue();
            var lst = res.LastOrDefault();

            if(poped.level == prev.level) {
                res.LastOrDefault().Add(poped.node.val);
            } else {
                res.Add(new List<int>() {poped.node.val});
            }

            if(poped.node.left != null) {
                q.Enqueue(new Node(poped.node.left, poped.level + 1));
            }

            if(poped.node.right != null) {
                q.Enqueue(new Node(poped.node.right, poped.level + 1));
            }

            prev = poped;
        }

        return res;
    }
}

public class Node {
    public TreeNode node;
    public int level;

    public Node(TreeNode n, int l) {
        node = n;
        level = l;
    }
}