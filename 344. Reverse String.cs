// https://leetcode.com/problems/reverse-string/
// Write a function that takes a string as input and returns the string reversed.

public class Solution344
{
    public string ReverseString(string s)
    {
        var arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}