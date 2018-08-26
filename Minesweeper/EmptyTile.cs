using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class EmptyTile : Tile
    {
        public override bool IsBomb()
        {
            return false;
        }

        public override int GetAdjacentMines()
        {
            throw new NotImplementedException();
        }

        public override int SetAdjacentMines(int adjacentMines)
        {
            
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
