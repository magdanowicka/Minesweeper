using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class FlaggedTile : TileDecorator
    {
        public FlaggedTile(Tile baseComponent) : base(baseComponent)
        {

        }

        public override bool IsOpened()
        {
            return false;
        }

        public override Tile Open()
        {
            return this;
        }

        public override Tile Flag()
        {
            return new ClosedTile(this);
        }
    }
}
