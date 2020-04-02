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
                for (int j = 0; j < gridSize; j++)
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

        public static void SetShips(char[,] grid)
        {
            grid[0, 0] = 'C';
            grid[0, 1] = 'C';
            grid[0, 2] = 'C';
            grid[0, 3] = 'C';
            grid[0, 4] = 'C';

            grid[7, 0] = 'B';
            grid[7, 1] = 'B';
            grid[7, 2] = 'B';
            grid[7, 3] = 'B';

            grid[5, 7] = 'S';
            grid[6, 7] = 'S';
            grid[7, 7] = 'S';
        }

        static void CheckHit(char row, char col, char[,] display, char[,] enemy)
        {
            int x, y;
            y = 0;

            switch (row)
            {
                case 'A':
                    y = 0;
                    break;
                case 'B':
                    y = 1;
                    break;
                case 'C':
                    y = 2;
                    break;
                case 'D':
                    y = 3;
                    break;
                case 'E':
                    y = 4;
                    break;
                case 'F':
                    y = 5;
                    break;
                case 'G':
                    y = 6;
                    break;
                case 'H':
                    y = 7;
                    break;

            }


            x = Int32.Parse(col.ToString()) - 1;

            if (enemy[y, x] != '.')
            {
                Console.WriteLine("A hit!");
                enemy[y, x] = 'X';
                display[y, x] = 'X';
                DisplayGrid(displaygrid, 8);
            }
            else
            {
                Console.WriteLine("A miss!");
                enemy[y, x] = 'O';
                display[y, x] = 'O';
                DisplayGrid(displaygrid, 8);
            }
        }

        static void Main(string[] args)
        {
            displaygrid = new char[8, 8];
            enemygrid = new char[8, 8];

            CreateEmptyGrid(displaygrid, 8);
            CreateEmptyGrid(enemygrid, 8);
            DisplayGrid(displaygrid, 8);
            SetShips(enemygrid);
            //DisplayGrid(enemygrid, 8);

            while (true)
            {
                Console.Write("Enter A Grid reference in the format 'A3'");
                string input = Console.ReadLine();
                char row = input[0];
                char col = input[1];
                CheckHit(row, col, displaygrid, enemygrid);
            }

            Console.ReadLine();
        }
    }
}