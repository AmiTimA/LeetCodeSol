// https://leetcode.com/problems/reverse-integer/

// Given a 32-bit signed integer, reverse digits of an integer.
// Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range.
// For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

#include "pch.h" // User Header file
#include <iostream> // System Header file

/* Iterative function to reverse digits of num*/
int reversDigits(int num)
{
	// Handling negative numbers 
	bool negativeFlag = false;
	if (num < 0)
	{
		negativeFlag = true;
		num = -num;
	}

	int prev_rev_num = 0, rev_num = 0;
	while (num != 0)
	{
		int curr_digit = num % 10;

		rev_num = (rev_num * 10) + curr_digit;

		// checking if the reverse overflowed or not. 
		// The values of (rev_num - curr_digit)/10 and 
		// prev_rev_num must be same if there was no 
		// problem. 
		if ((rev_num - curr_digit) / 10 != prev_rev_num)
		{
			printf("WARNING OVERFLOWED!!!\n");
			return 0;
		}

		prev_rev_num = rev_num;
		num = num / 10;
	}

	return (negativeFlag == true) ? -rev_num : rev_num;
}

int main()
{
	std::cout << "Hello World!\n";

	int num = 12345;
	printf("Reverse of no. is %d\n", reversDigits(num));

	num = 1000000045;
	printf("Reverse of no. is %d\n", reversDigits(num));

	return 0;
}