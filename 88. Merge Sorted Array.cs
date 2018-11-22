// https://leetcode.com/problems/merge-sorted-array/
// Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // Base case
        
        int index1 = m - 1;
        int index2 = n - 1;
        int indexTarget = nums1.Length - 1;
        
        while (index1 >= 0 && index2 >= 0)
        {
            if (nums1[index1] >= nums2[index2])
            {
                nums1[indexTarget--] = nums1[index1--];
            }
            else
            {
                nums1[indexTarget--] = nums2[index2--];
            }
        }
        
        if (index1 >= 0)
        {
            while(index1 >= 0)
            {
                nums1[indexTarget--] = nums1[index1--];
            }
        }
        
        if (index2 >= 0)
        {
            while(index2 >= 0)
            {
                nums1[indexTarget--] = nums2[index2--];
            }
        }
    }
}