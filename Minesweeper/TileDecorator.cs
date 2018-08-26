using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public abstract class TileDecorator : Tile
    {
        Tile tile = null;

        protected TileDecorator(Tile baseComponent)
        {
            tile = baseComponent;
        }

        public override bool IsBomb()
        {
            return tile.IsBomb();
        }

        public override int GetAdjacentMines()
        {
            return tile.GetAdjacentMines();
        }

        public override void SetAdjacentMines(int adjacentMines)
        {
            tile.SetAdjacentMines(adjacentMines);
        }

    }
}
