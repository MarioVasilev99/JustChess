namespace JustChess.Engine.Initializations
{
    using System;
    using System.Collections.Generic;
    using JustChess.Board.Contracts; 
    using JustChess.Engine.Contracts;
    using JustChess.Players.Contracts;

    public class StandartStartGameInitializationStrategy : IGameInitializationStrategy
    {
        private const int NumberOfPlayers = 2;
        private const int BoardTotalRowsAndCols = 8;

        public void Initialize(ICollection<IPlayer> players, IBoard board)
        {
            this.ValidateStrategy(players, board);
        }

        private void ValidateStrategy(ICollection<IPlayer> players, IBoard board)
        {
            if (players.Count != NumberOfPlayers)
            {
                throw new InvalidOperationException("Standart Start Game Initialization Strategy needs exactly two players!");
            }

            if (board.TotalRows != BoardTotalRowsAndCols || board.TotalCols != BoardTotalRowsAndCols)
            {
                throw new InvalidOperationException("Standart Start Game Initialization Strategy needs 8x8 board!");
            }
        }
    }
}
