using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class ClosedTile : TileDecorator
    {
        public ClosedTile(Tile baseComponent) : base(baseComponent)
        {

        }

        public override bool IsOpened()
        {
            return false;
        }

        public override Tile Open()
        {
            return new OpenedTile(this);
        }

        public override Tile Flag()
        {
            return new FlaggedTile(this);
        }        
    }
}
