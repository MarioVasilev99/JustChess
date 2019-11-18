﻿namespace JustChess.Figures
{
    using JustChess.Common;
    using JustChess.Figures.Contracts;
    public class Pawn : BaseFigure, IFigure
    {
        public Pawn(ChessColor color)
         : base(color)
        {
        }
    }
}
