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
        // List<int> items = new List<int>();
        Stack<TreeNode> collection = new Stack<TreeNode>();
        // HashSet<TreeNode> visited = new HashSet<TreeNode>();

        var cur = root;
        int n = 0;
        while(n < k) {
            while(cur != null) {
                collection.Push(cur);
                cur = cur.left;
            }

            cur = collection.Pop();
            n++;
            if(n == k) {
                return cur.val;
            }

            cur = cur.right;
        }

        return -1;

        /*
        if(root != null) {
            collection.Push(root);
            visited.Add(root);
        }

        while(collection.Count > 0 || items.Count < k) {
            var current = collection.Pop();

            // go to left child
            if(current.left != null && !visited.Contains(current.left)) {
            collection.Push(current);
            collection.Push(current.left);
            visited.Add(current.left);

            continue;
            }

            // process current node
            items.Add(current.val);

            // go to right child
            if(current.right != null) {
                collection.Push(current.right);
            }
        }

        return items[k - 1];

        */
        /*
        VisitBST(root, items, k);

        return items[k - 1];
        */
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