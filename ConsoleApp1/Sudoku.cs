using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Sudoku
    {
        private int cellValue;

		public int Cell
		{
			get { return cellValue; }
			set { cellValue = value; }
		}

        public static bool isCaseEqual(int cellValue)
        {
            return true;
        }
        public static bool isCaseEmpty(int cellValue)
        {
            return isCaseEqual(cellValue);
        }

    }
}
