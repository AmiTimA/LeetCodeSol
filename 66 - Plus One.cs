// https://leetcode.com/problems/plus-one/description/

// Given a non-empty array of digits representing a non-negative integer, plus one to the integer.
// The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.
// You may assume the integer does not contain any leading zero, except the number 0 itself.

public class Solution {
    public int[] PlusOne(int[] digits) {
        return PlusOneRecursive(digits, digits.Length - 1);
    }
    
    private int[] PlusOneRecursive(int[] digits, int index) {
        
        // In case index is -1
        if (index == -1) {
            int[] newArray = new int[digits.Length + 1];
            newArray[0] = 1;
            newArray[1] = 0;
            for(int i = 2; i < newArray.Length; i++) {
                newArray[i] = 0;
            }
            return newArray;
        }
        
        if (digits[index] < 9) {
            digits[index] = digits[index] + 1;
            return digits;
        }
        else {
            digits[index] = 0;
            return PlusOneRecursive(digits, index - 1);
        }        
    }
}