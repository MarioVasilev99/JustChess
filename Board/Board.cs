namespace JustChess.Board
{
    using System;
    using JustChess.Board.Contracts;
    using JustChess.Common;
    using JustChess.Figures.Contracts;

    public class Board : IBoard
    {
        private readonly IFigure[,] board;

        public Board(
            int rows = GlobalConstants.StandartGameTotalBoardRows,
            int cols = GlobalConstants.StandartGameTotalBoardCols)
        {
            this.TotalRows = rows;
            this.TotalCols = cols;
            this.board = new IFigure[rows, cols];
        }

        public int TotalRows { get; private set; }

        public int TotalCols { get; private set; }

        public void AddFigure(IFigure figure, Position position)
        {
            ObjectValidator.CheckIfObjectIsNull(figure, GlobalErrorMessages.NullFigureErrorMessage);
            this.CheckIfPositionIsValid(position);

            int arrayRow = this.GetArrayRow(position.Row);
            int arrayCol = this.GetArrayCol(position.Col);
            this.board[arrayRow, arrayCol] = figure;
        }

        public void RemoveFigure(Position position)
        {
            this.CheckIfPositionIsValid(position);

            int arrayRow = this.GetArrayRow(position.Row);
            int arrayCol = this.GetArrayCol(position.Col);
            this.board[arrayRow, arrayCol] = null;
        }

        private int GetArrayRow(int chessRow)
        {
            return this.TotalRows - chessRow;
        }

        private int GetArrayCol(char chessCol)
        {
            return chessCol - 'a';
        }

        private void CheckIfPositionIsValid(Position position)
        {
            if (position.Row < GlobalConstants.MinimumRowValueOnBoard
                || position.Row > GlobalConstants.MaximumRowValueOnBoard)
            {
                throw new IndexOutOfRangeException("Selected row position on the board is not valid!");
            }

            if (position.Col < GlobalConstants.MinimumColumnValueOnBoard
                || position.Col > GlobalConstants.MaximumColumnValueOnBoard)
            {
                throw new IndexOutOfRangeException("Selected column position on the board is not valid!");
            }
        }
    }
}
