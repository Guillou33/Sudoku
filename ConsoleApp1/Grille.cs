using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Grille
    {
		private int cellX;

		public int lineCell
		{
			get { return cellX; }
			set { cellX = value; }
		}

		private int cellY;

		public int columnCell
		{
			get { return cellY; }
			set { cellY = value; }
		}
	}
}
