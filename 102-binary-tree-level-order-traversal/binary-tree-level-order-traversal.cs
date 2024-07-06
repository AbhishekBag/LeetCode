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
        Queue<QNode> queue = new Queue<QNode>();

        if(root == null) {
            return res;
        }

        queue.Enqueue(new QNode(root, 0));

        while(queue.Count > 0) {
            var poped = queue.Dequeue();
            if(res.Count == 0 || res.Count == poped.level) {
                res.Add(new List<int>() { poped.node.val });
            } else {
                res.LastOrDefault().Add(poped.node.val);
            }

            if(poped.node.left != null) {
                queue.Enqueue(new QNode(poped.node.left, poped.level + 1));
            }

            if(poped.node.right != null) {
                queue.Enqueue(new QNode(poped.node.right, poped.level + 1));
            }
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