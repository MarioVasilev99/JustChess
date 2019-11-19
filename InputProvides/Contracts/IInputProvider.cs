namespace JustChess.InputProvides.Contracts
{
    using System.Collections.Generic;
    using JustChess.Players.Contracts;

    public interface IInputProvider
    {
        IList<IPlayer> GetPlayers(int numberOfPlayers);
    }
}
