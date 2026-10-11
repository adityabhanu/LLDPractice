using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.TicTacToe.Models
{
    public class Board
    {
        public int size;
        public PlayingPiece[,] board;

        public Board(int _size)
        {
            this.size = _size;
            this.board = new PlayingPiece[size, size];
        }

        public bool addPiece(PlayingPiece piece, int row, int column)
        {
            if (this.board[row, column] == null)
            {
                this.board[row, column] = piece;
                return true;
            }

            Console.WriteLine("Incorrect position");
            return false;


        }

        public bool hasFreeCells()
        {
            for (int row = 0; row < this.size; row++)
            {
                for (int column = 0; column < this.size; column++)
                {
                    if (this.board[row, column] == null)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void printBoard()
        {
            for (int row = 0; row < this.size; row++)
            {
                for (int column = 0; column < this.size; column++)
                {
                    Console.WriteLine($"{this.board[row, column]}");
                    Console.WriteLine(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}
