// Populating Next Right Pointers in Each Node
// https://leetcode.com/explore/learn/card/data-structure-tree/133/conclusion/994/

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
        //Base Case
        if(root == NULL){
            return;
        }
        
        // Need two pointers
        TreeLinkNode *pre = root;
        TreeLinkNode *curr = NULL;
        
        while(pre->left){
            curr = pre;
            
            while(curr){
                curr->left->next = curr->right;
                if(curr->next) curr->right->next = curr->next->left;
                curr = curr->next;
            }
                
            pre = pre->left;
        }
    }
};