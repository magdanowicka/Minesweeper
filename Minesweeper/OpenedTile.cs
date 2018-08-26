using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class OpenedTile : TileDecorator
    {
        public OpenedTile(Tile baseComponent) : base(baseComponent)
        {

        }        

        public override Tile Open()
        {
            return this;
        }

        public override Tile Flag()
        {
            return this;
        }           
    }
}
