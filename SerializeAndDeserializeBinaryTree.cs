// Serialize and Deserialize Binary Tree
// https://leetcode.com/explore/learn/card/data-structure-tree/133/conclusion/995/
// https://www.geeksforgeeks.org/serialize-deserialize-binary-tree/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System.Collections.Generic;

public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        List<string> tempList = new List<string>();
        serializeHelper(root, tempList);
        return String.Join(",", tempList);
    }

    private void serializeHelper(TreeNode root, List<string> tempList){
        if(root == null){
            tempList.Add("null");
        }
        else{
            tempList.Add(root.val.ToString());
            serializeHelper(root.left, tempList);
            serializeHelper(root.right, tempList);
        }
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        Queue<string> tempList = new Queue<string>(data.Split(','));
        return Helper(tempList);
    }

    private TreeNode Helper(Queue<string> queue){
        string s = queue.Dequeue();
        
        if(s == "null"){
            return null;
        }

        TreeNode t = new TreeNode(Int32.Parse(s));
        t.left = Helper(queue);
        t.right = Helper(queue);

        return t;
    }
}