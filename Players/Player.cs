 namespace JustChess.Players
{
    using System;
    using System.Collections.Generic;
    using JustChess.Common;
    using JustChess.Figures.Contracts;
    using JustChess.Players.Contracts;

    public class Player : IPlayer
    {
        private readonly ICollection<IFigure> figures;

        public Player(string name, ChessColor color)
        {
            this.Name = name;
            this.Color = color;
            this.figures = new List<IFigure>();
        }

        public string Name { get; private set; }

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
