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

        Queue<QNode> q = new Queue<QNode>();
        res.Add(new List<int> { root.val });

        if(root.left != null) {
            q.Enqueue(new QNode(root.left, 1));
        }
        if(root.right != null) {
            q.Enqueue(new QNode(root.right, 1));
        }

        var prev = new QNode(root, 0);

        while(q.Count != 0) {
            var dq = q.Dequeue();

            // Console.WriteLine($"dq: ({dq.node.val}, {dq.level}), prev: ({prev.node.val}, {prev.level})");

            if(prev.level == dq.level) {
                res.LastOrDefault().Add(dq.node.val);
            } else {
                res.Add(new List<int> { dq.node.val });
            }

            if(dq.node.left != null) {
                q.Enqueue(new QNode(dq.node.left, dq.level + 1));
            }
            if(dq.node.right != null) {
                q.Enqueue(new QNode(dq.node.right, dq.level + 1));
            }

            prev = dq;
        }

        return res;
    }
}

public class QNode {
    public TreeNode node;
    public int level;

    public QNode(TreeNode n, int l) {
        node = n;
        level = l;
    }
}