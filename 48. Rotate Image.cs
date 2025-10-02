// https://leetcode.com/problems/rotate-image/

// You are given an n x n 2D matrix representing an image.
// Rotate the image by 90 degrees (clockwise).

// Method 1
public class Solution48
{
    public void Rotate(int[,] matrix)
    { // two-dimensional array

        // Base Case
        if (matrix == null || matrix.GetLength(0) < 2)
        {
            return;
        }

        // Find how many layers
        int size = matrix.GetLength(0);
        int layers = size / 2;

        for (int i = 0; i < layers; i++)
        {
            for (int j = i; j < size - i - 1; j++)
            {
                int temp = matrix[i, j];

                matrix[i, j] = matrix[size - j - 1, i];

                matrix[size - j - 1, i] = matrix[size - i - 1, size - j - 1];

                matrix[size - i - 1, size - j - 1] = matrix[j, size - i - 1];

                matrix[j, size - i - 1] = temp;
            }
        }
    }
} // Complexity => O(n.n)

// Method 2
// First reverse up to down, then swap the symmetry 
// https://leetcode.com/problems/rotate-image/discuss/18872/A-common-method-to-rotate-the-image

public class Solution48_2 {
    public void Rotate(int[,] matrix) {
        // Base Case
        if (matrix == null || matrix.GetLength(0) < 2) {
            return;
        }

        int size = matrix.GetLength(0);
                
        // First upside down matrix
        for (int i = 0; i < size / 2; i++) {
            for (int j = 0; j < size; j++) {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[size - i - 1, j];
                matrix[size - i - 1, j] = temp;
            }
        }        
        
        // Reverse symmetry -> Convert Rows to Columns and Columsn to Rows
        for (int i = 0; i < size; i++) {
            for (int j = i; j < size; j++) {
                if(i != j) {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
        }
    }
} // Complexity => O(n.n)