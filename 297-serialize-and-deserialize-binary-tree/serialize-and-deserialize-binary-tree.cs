/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {
    private int i = 0;
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        List<string> res = new List<string>();
        DFSSerialize(root, res);

        return string.Join(",", res);
    }

    private void DFSSerialize(TreeNode node, List<string> res) {
        if(node == null) {
            res.Add("N");
            return;
        }

        res.Add(node.val.ToString());
        DFSSerialize(node.left, res);
        DFSSerialize(node.right, res);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        var arr = data.Split(",");

        return CreateTreeDFS(arr);
    }

    private TreeNode CreateTreeDFS(string[] arr) {
        if(i >= arr.Length || arr[i] == "N") {
            i++;
            return null;
        }

        TreeNode node = new TreeNode(Int32.Parse(arr[i]));
        i++;
        node.left = CreateTreeDFS(arr);
        node.right = CreateTreeDFS(arr);
        return node;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));