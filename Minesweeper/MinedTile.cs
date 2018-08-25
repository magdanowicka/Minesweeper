using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class MinedTile : Tile
    {
        public override bool IsBomb()
        {
            return true;
        }

        public override int GetAdjacentMines()
        {
            throw new NotImplementedException();
        }

        public override int SetAdjacentMines(int adjacentMines)
        {
            throw new NotImplementedException();
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
