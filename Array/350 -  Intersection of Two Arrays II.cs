// https://leetcode.com/problems/intersection-of-two-arrays-ii/description/

// Given two arrays, write a function to compute their intersection.

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> nums1Dict = new Dictionary<int, int>();
        
        foreach(int i in nums1) {
            if (nums1Dict.ContainsKey(i)) {
                nums1Dict[i] = nums1Dict[i] + 1;
            }
            else {
                nums1Dict.Add(i, 1);
            }
        }
        
        List<int> result = new List<int>();
        
        foreach(int j in nums2) {
            if(nums1Dict.ContainsKey(j)) {
                result.Add(j);
                nums1Dict[j] = nums1Dict[j] - 1;
                
                if(nums1Dict[j] == 0) {
                    nums1Dict.Remove(j);
                }
            }
        }
        
        // Convert result in array and return
        return result.ToArray();
    }
}

// What if the given array is already sorted? How would you optimize your algorithm?
// We can use two pointers, one for each array
