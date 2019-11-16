namespace JustChess.Engine
{
    using System.Collections.Generic;
    using JustChess.Engine.Contracts;
    using JustChess.Players.Contracts;

    class StandardTwoPlayerEngine : IChessEngine
    {
        private readonly IEnumerable<IPlayer> players;

        public void Initialize(IGameInitializationStrategy gameInitializationStrategy)
        {
            gameInitializationStrategy.Initialize();
        }

        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public void WinningConditions()
        {
            throw new System.NotImplementedException();
        }

        public void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IPlayer> Players
        {
            get
            {
                return new List<IPlayer>(this.players);
            }
        }
    }
}
