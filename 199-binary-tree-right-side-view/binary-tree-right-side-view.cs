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
 // 1. associate level with each node
 // 2. Use hashset to keep track of visited nodes
 // 3. res => List<int>
 // 4. BFS => insent a node with it's level into a queue
 // 5. pop from queue
 // 6. if the level is present in visited set, ignore else add it to res
 // 7. if not null. then enqueue right and left child on the queue with level => current level + 1
public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        List<int> res = new List<int>();

        if(root == null) {
            return res;
        }
        HashSet<int> visited = new HashSet<int>();
        Queue<(TreeNode node, int level)> currentSet = new Queue<(TreeNode node, int level)>();

        currentSet.Enqueue((root, 0));

        while(currentSet.Count() > 0) {
            var current = currentSet.Dequeue();
            // Console.WriteLine($"Processing: {current.node.val} at level: {current.level}");

            if(!visited.Contains(current.level)) {
                // Console.WriteLine($"Added {current.node.val}");
                res.Add(current.node.val);
                visited.Add(current.level);
            }
            
            if(current.node.right != null) {
                // Console.WriteLine($"inserting: {current.node.right.val}");
                currentSet.Enqueue((current.node.right, current.level + 1));
            }
            if(current.node.left != null) {
                // Console.WriteLine($"inserting: {current.node.left.val}");
                currentSet.Enqueue((current.node.left, current.level + 1));
            }
        }

        return res;
    }
}