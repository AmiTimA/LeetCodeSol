// https://leetcode.com/problems/first-unique-character-in-a-string/

// Read following link to improve slightly this solution
// https://www.geeksforgeeks.org/given-a-string-find-its-first-non-repeating-character/

// Problem:
// Given a string, find the first non-repeating character in it and return it's index. If it doesn't exist, return -1.

public class Solution {
    public int FirstUniqChar(string s) {
        // Base Case
        if (String.IsNullOrEmpty(s)) {
            return -1;
        }
        
        int charCount = 256;
        int[] countArray = new int[charCount];
        
        // Construct count array
        for (int i = 0; i < s.Length; i++) {
            countArray[s[i]]++;
        }
        
        // Iterate through input string again
        for (int j = 0; j < s.Length; j++) {
            if (countArray[s[j]] == 1) {
                return j;
            }
        }
        
        return -1;
    }
}
