namespace JustChess.Players
{
    using System;
    using System.Collections.Generic;
    using JustChess.Common;
    using JustChess.Figures.Contracts;

    public class Player
    {
        private readonly ICollection<IFigure> figures;

        public Player(ChessColor color)
        {
            this.figures = new List<IFigure>();
            this.Color = color;
        }

        public ChessColor Color { get; private set; }

        public void AddFigure(IFigure figure)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, GlobalErrorMessages.NullFigureErrorMessage);
            this.CheckIfFigureExists(figure);
            // TODO: check figure and player color

            this.figures.Add(figure);
        }

        public void RemoveFigure(IFigure figure)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, GlobalErrorMessages.NullFigureErrorMessage);
            this.CheckIfFigureDoesNotExist(figure);
            // TODO: check figure and player color

            this.figures.Remove(figure);
        }

        private void CheckIfFigureExists(IFigure figure)
        {
            if (this.figures.Contains(figure))
            {
                throw new InvalidOperationException("This player already owns this figure!");
            }
        }

        private void CheckIfFigureDoesNotExist(IFigure figure)
        {
            if (!this.figures.Contains(figure))
            {
                throw new InvalidOperationException("This player does not own this figure!");
            }
        }
    }
}
