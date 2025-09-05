using System;

class Program
{
    static char[,] board = new char[3, 3];
    static char currentPlayer = 'X';

    static void Main()
    {
        InitializeBoard();
        while (true)
        {
            DrawBoard();
            PlayerMove();
            if (CheckWin())
            {
                DrawBoard();
                Console.WriteLine($"Player {currentPlayer} wins!");
                break;
            }
            if (IsBoardFull())
            {
                DrawBoard();
                Console.WriteLine("It's a tie!");
                break;
            }
            SwitchPlayer();
        }
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                board[i, j] = ' ';
    }

    static void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine("  1 2 3");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + 1 + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("  -+-+-");
        }
    }

    static void PlayerMove()
    {
        int row, col;
        while (true)
        {
            Console.WriteLine($"Player {currentPlayer}, enter row and column (e.g., 1 3):");
            string input = Console.ReadLine();
            string[] parts = input.Split();
            if (parts.Length != 2 || !int.TryParse(parts[0], out row) || !int.TryParse(parts[1], out col))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            row--; col--; // adjust for 0-based index
            if (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ')
            {
                Console.WriteLine("Invalid move. Try again.");
                continue;
            }

            board[row, col] = currentPlayer;
            break;
        }
    }

    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    static bool IsBoardFull()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (board[i, j] == ' ')
                    return false;
        return true;
    }

    static bool CheckWin()
    {
        // Check rows & columns
        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) ||
                (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer))
                return true;
        }
        // Check diagonals
        if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
            (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
            return true;

        return false;
    }
}
