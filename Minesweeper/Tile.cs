using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public abstract class Tile
    {
        public abstract bool IsBomb();
        public abstract int GetAdjacentMines();
        public abstract int SetAdjacentMines(int adjacentMines);
        public abstract Tile Open();
        public abstract Tile Flag();
    }
}
