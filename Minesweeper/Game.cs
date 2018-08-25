using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Game
    {
        public Tile[,] Grid;

        public Game() {  }

        public void GenerateGrid(int width, int height, int mines)
        {           
            Grid = new Tile[width, height];
            PlaceMines(width, height, mines);
            FillGridWithEmptyTiles(width, height);                             
        }

        private void PlaceMines(int width, int height, int mines)
        {
            int placedMines = 0;
            Random rand = new Random();

            while (placedMines < mines)
            {
                int x = rand.Next(width);
                int y = rand.Next(height);

                if (!Grid[x, y].IsBomb())
                {
                    Grid[x, y] = new MinedTile();
                    placedMines += 1;
                }
            }
        }

        private void FillGridWithEmptyTiles(int width, int height)
        {
            for (int x = 0; x < width; x += 1)
            {
                for (int y = 0; y < height; y += 1)
                {
                    if (!Grid[x, y].IsBomb())
                    {
                        Grid[x, y] = new EmptyTile();
                    }
                }
            }          
        }
        
    }
}
