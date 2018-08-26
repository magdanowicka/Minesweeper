using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class EmptyTile : Tile
    {
        private static int tileAdjacentMinesCount;

        public override bool IsBomb()
        {
            return false;
        }

        public override bool IsOpened()
        {
            throw new NotImplementedException();
        }

        public override int GetAdjacentMinesCount()
        {
            return tileAdjacentMinesCount;
        }

        public override void SetAdjacentMinesCount(int adjacentMinesCount)
        {
            tileAdjacentMinesCount = adjacentMinesCount;
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
