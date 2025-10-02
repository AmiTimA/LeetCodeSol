// Find Duplicate
// https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1112/

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> tempSet = new HashSet<int>();
        
        for (int i = 0; i < nums.Length; i++){
            if(tempSet.Contains(nums[i])){
                return true;
            }
            tempSet.Add(nums[i]);
        }
        
        return false;
    }
}

