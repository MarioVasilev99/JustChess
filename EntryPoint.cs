namespace JustChess
{
    using System;
    using JustChess.Renderers;
    using JustChess.Renderers.Contracts;

    public class EntryPoint
    {
        public static void Main()
        {
            IRenderer renderer = new ConsoleRenderer();
            renderer.RenderMainMenu();

            Console.ReadLine();
        }
    }
}
