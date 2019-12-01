namespace JustChess.Engine
{
    using System.Collections.Generic;

    using JustChess.Board;
    using JustChess.Board.Contracts;
    using JustChess.Common;
    using JustChess.Engine.Contracts;
    using JustChess.InputProvides.Contracts;
    using JustChess.Players.Contracts;
    using JustChess.Renderers.Contracts;

    public class StandardTwoPlayerEngine : IChessEngine
    {
        private readonly IList<IPlayer> players;
        private readonly IRenderer renderer;
        private readonly IInputProvider input;
        private readonly IBoard board;

        public StandardTwoPlayerEngine(IRenderer renderer, IInputProvider inputProvider)
        {
            this.renderer = renderer;
            this.input = inputProvider;
            this.board = new Board();
        }

        public void Initialize(IGameInitializationStrategy gameInitializationStrategy)
        {
            var players = this.input.GetPlayers(GlobalConstants.StandartGameNumberOfPlayers);
            gameInitializationStrategy.Initialize(players, this.board);
            this.renderer.RenderBoard(this.board);
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
