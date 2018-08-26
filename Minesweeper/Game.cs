using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Game
    {
        enum State { Ongoing, Won, Lost }

        private Grid grid;
        private int width;
        private int height;
        private int mines;
        private State state;

        public Game(int width, int height, int mines)
        {
            this.grid = Grid.Generate(width, height, mines);
            this.width = width;
            this.height = height;
            this.mines = mines;
            this.state = State.Ongoing;
        }       
        
        public void PrimaryMove(int x, int y)
        {
            if (IsGameOngoing())
            {
                var tile = grid.GetTile(x, y);
                tile.Open();
                if (tile.IsBomb()) 
                {
                    this.state = State.Lost;
                }  
                else if (tile.GetAdjacentMinesCount() == 0)
                {

                }
            }                
        }

        public void SecondaryMove(int x, int y)
        {
            if (IsGameOngoing())
            {
                grid.GetTile(x, y).Flag();
            }            
        }

        private bool IsGameOngoing()
        {
            return this.state == State.Ongoing;
        }

        public bool IsSuccess()
        {
            return grid.GetNumberOfOpenedEmptyTiles() == GetNumberOfEmptyTiles();
        }

        private int GetNumberOfEmptyTiles()
        {
            return (width * height) - mines;
        }             
    }
}