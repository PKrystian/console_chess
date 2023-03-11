using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace console_chess
{
    public class chess_main
    {
        static void Main(string[] args)
        {
            char[,] chess_board = new char[9, 9]
            {
                {'0', '1', '2', '3', '4', '5', '6', '7', '8'},
                {'1', 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R'},
                {'2', 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P'},
                {'3', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {'4', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {'5', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {'6', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' '},
                {'7', 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p'},
                {'8', 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r'}
            };

            Console.WriteLine("+---+---+---+---+---+---+---+---+---+");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(chess_board[i, j] + " | ");
                }
                Console.WriteLine();
                Console.WriteLine("+---+---+---+---+---+---+---+---+---+");
            }
        }
    }
}