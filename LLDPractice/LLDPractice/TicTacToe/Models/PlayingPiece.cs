using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.TicTacToe.Models
{
    public class PlayingPiece
    {
        public PieceTypeEnum type;
        
        public PlayingPiece(PieceTypeEnum _type)
        {
            this.type = _type;
        }
    }
}
