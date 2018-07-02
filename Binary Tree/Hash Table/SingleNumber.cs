// Single Number
// https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1176/

public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> tempSet = new HashSet<int>();
        
        for( int i = 0; i < nums.Length; i++){
            if(tempSet.Contains(nums[i])){
                tempSet.Remove(nums[i]);
            }
            else {
                tempSet.Add(nums[i]);
            }
        }
        
        return tempSet.First();
    }
}