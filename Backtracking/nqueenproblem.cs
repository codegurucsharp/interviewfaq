using System;

namespace Backtracking
{
    public class NQueenProblem
    {
        public void ExecuteNQueenProblem()
        {
            int[,] board = {
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0}
            };
            // int[,] board = {
            //     {1, 2, 3, 4},
            //     {5, 6, 7, 8},
            //     {9, 10, 11, 12},
            //     {13, 14, 15, 0},
            // };

            // int[,] board = {
            //     {0, 0, 0, 0},
            //     {0, 0, 0, 0},
            //     {0, 0, 0, 0},
            //     {0, 0, 0, 0},
            // };

            if (solveNQUtil(board, 6, 0) == false)
            {
                System.Console.WriteLine("Solution does not exist");
                return;
            }

            printSolution(board);
            return;
        }
        private void printSolution(int[,] board)
        {
            int length = board.GetLength(0);
            int height = board.GetLength(1);

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    System.Console.Write(" {0} ", board[i, j]);
                }

                System.Console.WriteLine();
            }
        }

        private bool isValidPosition(int row, int col, int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < col; j++)
                {
                    // Same Row check
                    if (row == i && board[i, j] == 1) return false;

                    //Same column check not needed
                    //if (col == j && board[i, j] == 1) return false;
                    if (Math.Abs(i - row) == Math.Abs(j - col) && board[i, j] == 1) return false;
                }
            }

            return true;
        }

        private bool isValidPosition2(int row, int col, int[,] board)
        {
            // Check that it's not a common row
            for (int i = 0; i < col; i++)
                if (board[row, i] == 1) return false;

            // check left upper side diagonal like: \
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i, j] == 1) return false;

            // check left down side diagonal like: /
            for (int i = row, j = col; i < board.GetLength(0) && j >= 0; i++, j--)
                if (board[i, j] == 1) return false;

            return true;
        }

        public bool solveNQUtil(int[,] board, int size, int col)
        {
            if (col == size)
            {
                printSolution(board);
                return true;
            }

            for (int i = 0; i < size; i++)
            {
                if (isValidPosition2(i, col, board))
                {
                    board[i, col] = 1;

                    // if (solveNQUtil(board, size, col + 1)) return true;
                    solveNQUtil(board, size, col + 1);

                    board[i, col] = 0;
                }
            }

            return false;
        }
    }
}