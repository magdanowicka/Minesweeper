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

        public override bool IsOpened()
        {
            throw new NotImplementedException();
        }

        public override int GetAdjacentMinesCount()
        {
            throw new NotImplementedException();
        }

        public override void SetAdjacentMinesCount(int adjacentMinesCount)
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
