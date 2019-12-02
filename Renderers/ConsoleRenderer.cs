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
        private const int CharactersPerRowPerBoardSquare = 9;
        private const int CharactersPerColPerBoardSquare = 9;
        private const ConsoleColor DarkSquareConsoleColor = ConsoleColor.DarkGray;
        private const ConsoleColor LightSquareConsoleColor = ConsoleColor.Gray;

        public void RenderMainMenu()
        {
            ConsoleHelpers.SetCursorAtCenter(Logo.Length);
            Console.WriteLine(Logo);

            //TODO: add main menu
            Thread.Sleep(1000);

        }

        public void RenderBoard(IBoard board)
        {
        //Console.BackgroundColor = ConsoleColor.Blue;
        //Console.Write(" ");

        //Console.ReadLine();

        //ToDo: Validate console dimensions
            var startRowPrint = Console.WindowHeight / 2 - (board.TotalRows / 2) * CharactersPerRowPerBoardSquare;
            var startColPrint = Console.WindowWidth / 2 - (board.TotalCols / 2) * CharactersPerColPerBoardSquare;

            var currentRowPrint = startRowPrint;
            var currentColPrint = startColPrint;

            Console.BackgroundColor = ConsoleColor.White;
            int counter = 0;
            for (int top = 0; top < board.TotalRows; top++)
            {
                for (int left = 0; left < board.TotalCols; left++)
                {
                    currentRowPrint = startRowPrint + left * CharactersPerColPerBoardSquare;
                    currentColPrint = startColPrint + top * CharactersPerRowPerBoardSquare;

                    if (counter % 2 == 0)
                    {
                        Console.BackgroundColor = DarkSquareConsoleColor;
                    }
                    else
                    {
                        Console.BackgroundColor = LightSquareConsoleColor;
                    }

                    Console.SetCursorPosition(currentColPrint, currentRowPrint);
                    Console.Write(" ");

                    for (int i = 0; i < CharactersPerRowPerBoardSquare; i++)
                    {
                        for (int j = 0; j < CharactersPerColPerBoardSquare; j++)
                        {
                            Console.SetCursorPosition(currentColPrint + j, currentRowPrint + i);
                            Console.Write(" ");
                        }
                    }

                    counter++;
                }
                counter++;
            }

            Console.ReadLine();
        }
    }
}
