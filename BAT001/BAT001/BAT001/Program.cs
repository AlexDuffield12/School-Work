using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAT001
{
    class Program
    {
        //declaring the grid
        static char[,] displaygrid;
        static char[,] enemygrid;
        public static char[,] CreateEmptyGrid(char[,] grid, int gridSize)
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; i++)
                {
                    grid[i, j] = '.';
                }
            }
            return grid;
        }

        public static void DisplayGrid(char[,] grid, int gridSize)
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            displaygrid = new char[8, 8];
            enemygrid = new char[8, 8];

            CreateEmptyGrid(displaygrid, 8);
            CreateEmptyGrid(enemygrid, 8);

            Console.ReadLine();
        }
    }
}