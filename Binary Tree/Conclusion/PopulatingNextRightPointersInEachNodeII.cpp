// Populating Next Right Pointers in Each Node II
// https://leetcode.com/explore/learn/card/data-structure-tree/133/conclusion/1016/

/**
 * Definition for binary tree with next pointer.
 * struct TreeLinkNode {
 *  int val;
 *  TreeLinkNode *left, *right, *next;
 *  TreeLinkNode(int x) : val(x), left(NULL), right(NULL), next(NULL) {}
 * };
 */
class Solution {
public:
    void connect(TreeLinkNode *root) {
        if(root == NULL){
            return;
        }
        
        // Need three pointers
        TreeLinkNode *curr = root; // Current Node of current Level
        TreeLinkNode *head = NULL; // Head of the next level
        TreeLinkNode *prev = NULL; // the leading node on the next level
        
        while(curr != NULL) {
            // Iterate the current level
            while(curr != NULL){
                // Left Child
                if(curr->left != NULL) {
                    if(prev != NULL){
                        prev->next = curr->left;
                    }
                    else {
                        head = curr->left;
                    }
                    prev = curr->left;
                }
                
                // Right Child
                if(curr->right != NULL) {
                    if(prev != NULL){
                        prev->next = curr->right;
                    }
                    else {
                        head = curr->right;
                    }
                    prev = curr->right;
                }
                
                // Move to next node
                curr = curr->next;
            }
            
            // Move to next level
            curr = head;
            head = NULL;
            prev = NULL;
        }
    }
};