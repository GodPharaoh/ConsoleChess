using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    internal class Board
    {
        #region Fields 
        private int[] yLocator;
        private int[] xLocator;
        private string[] yDefinition;
        private string[] xDefinition;
        private string[,] chessBoard;
        private string[] boardFrames;
        #endregion


        #region Properties
        /// <summary>
        /// Returns the chessboard numbers
        /// </summary>
        public string[,] ChessBoard
        { 
            get
            {
                return chessBoard;
            }
        }
        #endregion


        #region Constructor
        public Board()
        {
            yLocator = new int[8];
            xLocator = new int[8];
            yDefinition = new string[] 
            { 
                "8",
                "7",
                "6",
                "5",
                "4",
                "3",
                "2",
                "1" 
            };
            xDefinition = new string[]
            {
                "a",
                "b",
                "c",
                "d",
                "e",
                "f",
                "g",
                "h",
            };
            // [ rows , columns ]
            chessBoard = new string[xLocator.Length,yLocator.Length];
            for (int i = 0; i < yDefinition.Length; i++)
            {
                for (int j = 0; j < xDefinition.Length; j++)
                {
                    chessBoard[i, j] = String.Format(
                        xDefinition[j] + yDefinition[i]);
                }
            }
            boardFrames = new string[]
            {
                "╔═══════════════════════════════════════════╗",
                "║                                           ║",
                "╚═══════════════════════════════════════════╝"
            };

        }
        #endregion


        #region Methods
        public void PrintBoard()
        {
            int rows = chessBoard.GetLength(0);
            int cols = chessBoard.GetLength(1);

            // top of board frame
            Console.WriteLine(boardFrames[0]);
            // center board frame
            Console.WriteLine(boardFrames[1]);

            // [ rows , columns ]
            for (int i = 0; i < cols; i++)
            {
                // left side of board frame
                Console.Write("║   ");
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(chessBoard[i, j] + "   ");
                }
                // right side of board frame
                Console.Write("║\n");
                // center board frame
                Console.WriteLine(boardFrames[1]);
            }

            // bottom of board frame
            Console.WriteLine(boardFrames[2]);
        }
        #endregion


    }
}
