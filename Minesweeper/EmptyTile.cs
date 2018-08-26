using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class EmptyTile : Tile
    {
        private static int numberOfAdjacentMines;

        public override bool IsBomb()
        {
            return false;
        }

        public override int GetAdjacentMines()
        {
            return numberOfAdjacentMines;
        }

        public override void SetAdjacentMines(int adjacentMines)
        {
            numberOfAdjacentMines = adjacentMines;
        }

        public override Tile Open()
        {
            throw new NotImplementedException();
        }

        public override Tile Flag()
        {
            throw new NotImplementedException();
        }        
    }
}
