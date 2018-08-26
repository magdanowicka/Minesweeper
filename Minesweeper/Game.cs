using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Game
    {
        public Grid Grid;
        public Game() { }

        public void GenerateGrid(int width, int height, int mines)
        {
            Grid = Grid.Generate(width, height, mines);
        }        
        
        public void PrimaryMove(int x, int y)
        {
            Grid[x, y].Open();
        }

        public void SecondaryMove(int x, int y)
        {
            Grid[x, y].Flag();
        }
    }
}