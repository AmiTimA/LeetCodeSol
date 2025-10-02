// https://leetcode.com/problems/move-zeroes/description/
// https://www.geeksforgeeks.org/move-zeroes-end-array/

public class Solution {
    public void MoveZeroes(int[] nums) {
        int index = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                nums[index] = nums[i];
                index++;
            }
        }
        
        for (int j = index; j < nums.Length; j++) {
            nums[j] = 0;
        }
    }
}
