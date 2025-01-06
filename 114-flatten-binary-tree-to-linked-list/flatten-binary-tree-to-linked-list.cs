public class Solution {
    private TreeNode prev = null;

    public void Flatten(TreeNode root) {
        if (root == null) return;

        // Recursively flatten the right subtree first
        Flatten(root.right);

        // Recursively flatten the left subtree
        Flatten(root.left);

        // Rewire the current node
        root.right = prev;
        root.left = null;

        // Move the "prev" pointer to the current node
        prev = root;
    }
}
