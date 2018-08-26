using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public sealed class NeighbourCoordinate
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        private static List<NeighbourCoordinate> neighbourCoordinates;

        private NeighbourCoordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        static NeighbourCoordinate()
        {
            neighbourCoordinates = new List<NeighbourCoordinate>();
            neighbourCoordinates.Add(new NeighbourCoordinate(-1, -1));
            neighbourCoordinates.Add(new NeighbourCoordinate(0, -1));
            neighbourCoordinates.Add(new NeighbourCoordinate(1, -1));
            neighbourCoordinates.Add(new NeighbourCoordinate(-1, 0));
            neighbourCoordinates.Add(new NeighbourCoordinate(0, 0));
            neighbourCoordinates.Add(new NeighbourCoordinate(1, 0));
            neighbourCoordinates.Add(new NeighbourCoordinate(-1, 1));
            neighbourCoordinates.Add(new NeighbourCoordinate(0, 1));
            neighbourCoordinates.Add(new NeighbourCoordinate(1, 1));
        }

        public static List<NeighbourCoordinate> GetNeighbourCoordinates()
        {
            return new List<NeighbourCoordinate>(neighbourCoordinates);
        }
    }
}
