namespace JustChess.Engine
{
    using System.Collections.Generic;

    using JustChess.Engine.Contracts;
    using JustChess.Players.Contracts;
    using JustChess.Renderers.Contracts;

    public class StandardTwoPlayerEngine : IChessEngine
    {
        private readonly IList<IPlayer> players;
        private readonly IRenderer renderer;

        public StandardTwoPlayerEngine(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public void Initialize(IGameInitializationStrategy gameInitializationStrategy)
        {
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
