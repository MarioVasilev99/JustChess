namespace JustChess
{
    using System;
    using JustChess.Engine;
    using JustChess.Engine.Contracts;
    using JustChess.Engine.Initializations;
    using JustChess.InputProvides;
    using JustChess.InputProvides.Contracts;
    using JustChess.Renderers;
    using JustChess.Renderers.Contracts;

    public static class ChessFacade
    {
        public static void Start()
        {
            IRenderer renderer = new ConsoleRenderer();
            //renderer.RenderMainMenu();

            IInputProvider inputProvider = new ConsoleInputProvider();

            IChessEngine chessEngine = new StandardTwoPlayerEngine(renderer, inputProvider);

            IGameInitializationStrategy gameInitializationStrategy = new StandartStartGameInitializationStrategy();

            chessEngine.Initialize(gameInitializationStrategy);
            chessEngine.Start();

            Console.ReadLine();
        }
    }
}
