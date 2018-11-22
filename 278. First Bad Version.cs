// https://leetcode.com/problems/first-bad-version/

// You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.
// Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.
// You are given an API bool isBadVersion(version) which will return whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {                
        
        return FirstBadVersionHelper(1, n);
    }
    
    public int FirstBadVersionHelper(int start, int end)
    {
        // Condition to stop recursion
        if (start > end)
            return start;            
        
        // Use binary search
        // int mid = (start + end) / 2; // This doesn't work
        int mid = start + (end - start)/2; // This works
        
        if (IsBadVersion(mid))
        {
            return FirstBadVersionHelper(start, mid - 1);
        }
        else
        {
            return FirstBadVersionHelper(mid + 1, end);
        }
    }    
}