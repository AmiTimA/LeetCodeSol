// Lowest Common Ancestor of a Binary Tree
// https://leetcode.com/explore/learn/card/data-structure-tree/133/conclusion/932/

// Method 1

/*
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        //Base Case
        if(root == null || p == null || q == null){
            return null;
        }
        
        // Create two lists
        List<TreeNode> firstList = new List<TreeNode>();
        List<TreeNode> secondList = new List<TreeNode>();
        
        if(!FindPath(root, p, firstList) || !FindPath(root, q, secondList)){
            return null;
        }
        
        // Find the diversion in both the lists
        int i = 0;
        for(i = 0; i < firstList.Count && i < secondList.Count; i++){
            if(firstList[i].val != secondList[i].val){                
                break;
            }
        }
        
        return firstList[i - 1];
    }
    
    private bool FindPath(TreeNode root, TreeNode node, List<TreeNode> list) {
        if(root == null){
            return false;
        }
        
        // Add root to the list
        list.Add(root);
        
        if(node.val == root.val){
            return true;
        }
        
        if(root.left != null && FindPath(root.left, node, list)){
            return true;
        }
        
        if(root.right != null && FindPath(root.right, node, list)){
            return true;
        }
        
        list.Remove(list[list.Count - 1]);
        return false;
        
    }
}