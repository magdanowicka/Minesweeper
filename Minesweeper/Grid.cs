using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Grid
    {
        private List<List<Tile>> tiles;

        private Grid(List<List<Tile>> tiles)
        {
            this.tiles = tiles;
        }

        public static Grid Generate(int width, int height, int mines)
        {
            List<List<Tile>> tiles = InitializeTiles(width, height);
            PlaceMines(tiles, mines);
            FillGridWithEmptyTiles(tiles);
            SetAdjacentMinesCount(tiles);
            return new Grid(tiles);
        }        

        private static List<List<Tile>> InitializeTiles(int width, int height)
        {
            List<List<Tile>> tiles = new List<List<Tile>>();
            for (int i = 0; i < height; i += 1)
            {
                List<Tile> row = new List<Tile>();
                for (int j = 0; j < width; j += 1)
                {
                    row.Add(null);
                }
                tiles.Add(row);
            }
            return tiles;
        }

        private static void PlaceMines(List<List<Tile>> tiles, int mines)
        {
            int placedMines = 0;
            Random rand = new Random();

            while (placedMines < mines)
            {
                int x = rand.Next(tiles.Count);
                int y = rand.Next(tiles[0].Count);

                if (tiles[x][y] != null)
                {
                    tiles[x][y] = new MinedTile();
                    placedMines += 1;
                }
            }
        }

        private static void FillGridWithEmptyTiles(List<List<Tile>> tiles)
        {            
            for (int x = 0; x < tiles.Count; x += 1)
            {
                for (int y = 0; y < tiles[0].Count; y += 1)
                {
                    if (tiles[x][y] == null)
                    {                        
                        tiles[x][y] = new EmptyTile();
                    }
                }
            }
        }

        private static void SetAdjacentMinesCount(List<List<Tile>> tiles)
        {
            for (int x = 0; x < tiles.Count; x += 1)
            {
                for (int y = 0; y < tiles[0].Count; y += 1)
                {
                    int adjacentMinesCount = GetAdjacentMinesCount(tiles, x, y);
                    tiles[x][y].SetAdjacentMinesCount(adjacentMinesCount);
                }
            }            
        }

        private static int GetAdjacentMinesCount(List<List<Tile>> tiles, int x, int y)
        {
            int adjacentMinesCount = 0;
            List<NeighbourCoordinate> coordinates = NeighbourCoordinate.GetNeighbourCoordinates();

            foreach (NeighbourCoordinate coordinate in coordinates)
            {
                if (CheckIfAdjacentTileIsBomb(tiles, x + coordinate.X, y + coordinate.Y))
                {
                    adjacentMinesCount++;
                }
            }
            return adjacentMinesCount;
        }

        private static bool CheckIfAdjacentTileIsBomb(List<List<Tile>> tiles, int x, int y)
        {
            if (x >= 0 && x < tiles.Count && y >= 0 && y < tiles[0].Count)
            {
                return tiles[x][y].IsBomb();
            }
            return false;
        }

        public Tile GetTile(int x, int y)
        {
            return tiles[x][y];
        }     

        public int GetNumberOfOpenedEmptyTiles()
        {
            int numberOfOpenedEmptyTiles = 0;
            for (int x = 0; x < tiles.Count; x += 1)
            {
                for (int y = 0; y < tiles[0].Count(); y += 1)
                {                   
                    if (tiles[x][y].IsOpened() && !tiles[x][y].IsBomb())
                    {
                        numberOfOpenedEmptyTiles++;
                    }
                }
            }
            return numberOfOpenedEmptyTiles;
        }
    }
}
