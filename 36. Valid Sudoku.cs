// https://leetcode.com/problems/valid-sudoku/description/

public class Solution {
    public bool IsValidSudoku(char[,] board) {
        // Base Case
        if (board == null || board.GetLength(0) != 9 || board.GetLength(1) != 9) {
            return false;
        }
        
        // Check each row
        for (int i = 0; i < 9; i++) {
            bool[] m = new bool[9];
            for (int j = 0; j < 9; j++) {
                if (board[i, j] != '.') { // this step is imp, we usually forget this
                    if (m[(int)(board[i, j] - '1')]) {
                        return false;
                    }
                    m[(int)(board[i, j] - '1')] = true;
                }                
            }
        }
        
        // Check each column
        for (int j = 0; j < 9; j++) {
            bool[] m = new bool[9];
            for (int i = 0; i < 9; i++) {
                if (board[i, j] != '.') {
                    if (m[(int)(board[i, j] - '1')]) {
                        return false;
                    }
                    m[(int)(board[i, j] - '1')] = true;
                }                
            }
        }
        
        // Check each 3*3 matrix block
        for (int block = 0; block < 9; block++) {
            bool[] m = new bool[9];
            for (int i = block / 3 * 3; i < block / 3 * 3 + 3; i++) {
                for (int j = block % 3 * 3; j < block % 3 * 3 + 3; j++) {
                    if (board[i, j] != '.') {
                        if (m[(int)(board[i, j] - '1')]) {
                            return false;
                        }
                        m[(int)(board[i, j] - '1')] = true;
                    }
                }                
            }
        }
        
        return true;        
    }
}