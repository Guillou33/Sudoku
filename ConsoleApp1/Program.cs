using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        

        public static int Randm(int min, int max)
        {
            Random rdm = new Random();
            int rdm2 = rdm.Next(min, max);
            return rdm2;
        }
       
        public static void fill(int[,] grille, List<int> verif)
        {
            bool caseOK = false;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    
                    while (caseOK == false)
                    {
                        //Console.WriteLine(grille[i, j]);

                        caseOK = Sudoku.isCaseEmpty(grille[i, j]);
                        
                        if (caseOK == false)
                        {
                            grille[i, j] = Randm(1, 9);
                        }
                    }
                }
            }
                
        }

        static void Main(string[] args)
        {
            int[,] grille = new int[9, 9];
            List<int> verif = new List<int>();


            fill(grille, verif);

            string ligne;

            for (int i = 0; i < 9; i++)
            {
                ligne = "";
                if (i == 0 || i == 3 || i == 6)
                {
                    ligne = ligne + "_____________";
                    Console.WriteLine(ligne);
                    ligne = "";
                }


                for (int j = 0; j < 9; j++)
                {
                    if (j == 0 || j == 3 || j == 6)
                    {
                        ligne = ligne + "|";
                    }
                    ligne = ligne + grille[i, j].ToString();
                    if (j == 8)
                    {
                        ligne = ligne + "|";
                    }
                }
                if (i == 8)
                {
                    ligne = ligne + "\n_____________";
                }
                Console.WriteLine(ligne);

            }


            return;

        }
    }
}
