using LLDPractice.TicTacToe.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LLDPractice.TicTacToe
{
    public class Game
    {
        public Queue<Player> players = new Queue<Player>();
        public Board board;

        public Game(int size)
        {
            this.board = new Board(size);
            InitGame();
        }

        public void InitGame()
        {
            PlayingPiece pieceX = new PieceX();
            Player player1 = new Player("Aditya", pieceX);

            PlayingPiece pieceO = new PieceO();
            Player player2 = new Player("Anamika", pieceO);

            this.players.Enqueue(player1);
            this.players.Enqueue(player2);


        }

        public string StartGame()
        {
            bool noWinner = true;

            while (noWinner)
            {
                Player currentPlayer = this.players.Dequeue();

                Console.WriteLine("Please enter you row position");
                int row = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter column position");
                int column = int.Parse(Console.ReadLine());

                bool pieceAdded = this.board.addPiece(currentPlayer.Piece, row, column);

                if (!pieceAdded)
                {

                    continue;
                }



            }

            return "";
        }


    }
}
