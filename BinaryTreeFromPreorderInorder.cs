// Construct Binary Tree from Preorder and Inorder Traversal
// https://leetcode.com/explore/learn/card/data-structure-tree/133/conclusion/943/

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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        // Base Case
        if(preorder == null || inorder == null || preorder.Length != inorder.Length){
            return null;
        }
        
        int preStart = 0;
        int preEnd = preorder.Length - 1;
        int inStart = 0;
        int inEnd = inorder.Length - 1;
        
        return Helper(preorder, preStart, preEnd, inorder, inStart, inEnd);
    }
    
    private TreeNode Helper(int[] preorder, int preStart, int preEnd, int[] inorder, int inStart, int inEnd){
        // Base Case
        if(preStart > preEnd || inStart > inEnd) {
            return null;
        }
        
        // Find the root
        TreeNode node = new TreeNode(preorder[preStart]);
        
        // Find the root in inorder
        int index = 0;
        for(int i = inStart; i <= inEnd; i++){
            if(node.val == inorder[i]){
                index = i;
                break;
            }            
        }
        
        // Find left and right subtrees
        node.left = Helper(preorder, preStart + 1, preStart + (index - inStart), inorder, inStart, index - 1);
        node.right = Helper(preorder, preStart + (index - inStart) + 1, preEnd, inorder, index + 1, inEnd);
        
        return node;
            
    }
}