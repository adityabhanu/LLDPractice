using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.TicTacToe.Models
{
    public class Player
    {
        public string Name { get; set; }
        public PlayingPiece Piece { get; set; }

        public Player(string _name,  PlayingPiece _piece)
        {
            this.Name = _name;
            this.Piece = _piece;
        }
    }
}
