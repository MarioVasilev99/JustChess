namespace JustChess.Figures
{
    using JustChess.Common;
    using JustChess.Figures.Contracts;

    public class Knight : BaseFigure, IFigure
    {
        public Knight(ChessColor color)
            : base(color)
        {
        }
    }
}
