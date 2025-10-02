// https://leetcode.com/problems/reverse-integer/

// Given a 32-bit signed integer, reverse digits of an integer.
// Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range.
// For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

public class Solution727
{
    public int Reverse(int x)
    {
        bool negativeFlag = false;

        if (x < 0)
        {
            negativeFlag = true;
            x = x * (-1);
        }

        int revNumber = 0;

        while (x != 0)
        {
            // Following line can overflow
            checked
            {
                try
                {
                    revNumber = (revNumber * 10) + (x % 10);
                }
                catch (OverflowException)
                {
                    return 0;
                }
            }

            x = x / 10;
        }

        return negativeFlag ? revNumber * (-1) : revNumber;
    }
}