using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    internal class Piece
    {
        #region Fields 
        protected int color;
        #endregion


        #region Properties
        /// <summary>
        /// Returns the color of the piece
        /// </summary>
        public int Color
        {
            get
            {
                return color;
            }
        }
        #endregion


        #region Constructor
        public Piece (int color)
        {
            this.color = color;
        }
        #endregion


        #region Methods

        #endregion


    }
}
