// Construct Binary Tree from Inorder and Postorder Traversal
// https://leetcode.com/explore/learn/card/data-structure-tree/133/conclusion/942/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        // Base Case
        if(inorder == null || postorder == null || inorder.Length != postorder.Length) {
            return null;
        }
        
        int inStart = 0;
        int inEnd = inorder.Length - 1;
        int postStart = 0;
        int postEnd = postorder.Length - 1;
        
        return Helper(inorder, inStart, inEnd, postorder, postStart, postEnd);
    }
    
    private TreeNode Helper(int[] inorder, int inStart, int inEnd, int[] postorder, int postStart, int postEnd){
        // Base Case
        if(inStart > inEnd || postStart > postEnd){
            return null;
        }
        
        // Get the root
        TreeNode node = new TreeNode(postorder[postEnd]);
        
        // Find root index in inorder
        int index = 0;
        for(int i = inStart; i <= inEnd; i++) {
            if(inorder[i] == node.val){
                index = i;
                break;
            }
        }
        
        // Call for Left and Right subtrees
        node.left = Helper(inorder, inStart, index - 1, postorder, postStart, postStart + (index - inStart) - 1);
        node.right = Helper(inorder, index + 1, inEnd, postorder, postStart + (index - inStart), postEnd - 1);
        
        return node;
    }
}