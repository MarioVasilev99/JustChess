namespace JustChess.InputProvides
{
    using System;
    using System.Collections.Generic;

    using JustChess.Common;
    using JustChess.Common.Console;
    using JustChess.InputProvides.Contracts;
    using JustChess.Players;
    using JustChess.Players.Contracts;

    public class ConsoleInputProvider : IInputProvider
    {
        public IList<IPlayer> GetPlayers(int numberOfPlayers)
        {
            var players = new List<IPlayer>();

            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.Clear();
                ConsoleHelpers.SetCursorAtCenter(0);
                Console.Write($"Enter Player {i} name: ");
                string name = Console.ReadLine();

                var player = new Player(name, (ChessColor)(i - 1));
                players.Add(player);
            }

            return players;
        }
    }
}
