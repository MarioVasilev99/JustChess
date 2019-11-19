namespace JustChess.Renderers
{
    using System;
    using System.Threading;

    using JustChess.Board.Contracts;
    using JustChess.Common.Console;
    using JustChess.Renderers.Contracts;

    public class ConsoleRenderer : IRenderer
    {
        private const string Logo = "JUST CHESS";

        public void RenderMainMenu()
        {
            ConsoleHelpers.SetCursorAtCenter(Logo.Length);
            Console.WriteLine(Logo);

            //TODO: add main menu
            Thread.Sleep(1000);

        }

        public void RenderBoard(IBoard board)
        {
            throw new System.NotImplementedException();
        }
    }
}
