using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConnectFour
{
    public class GameBoard
    {

        private int heightGrid;
        private int widthGrid;
        public List<List<int>> positions;
        public GameLogic gameLogic;

        public GameBoard(int height, int width)
        {
            heightGrid = height;
            widthGrid = width;
            positions = GridBuilding();
            gameLogic = new GameLogic();



        }

        public int GetLengthGrid()
        {
            return heightGrid;
        }


        private List<List<int>> GridBuilding()
        {

            List<List<int>> grid = new List<List<int>>();
            List<int> row = new List<int>();
            for (int x = 0; x < heightGrid; x++)
            {
                row.Clear();
                for (int y = 0; y < widthGrid; y++)
                {
                    
                    row.Add(0);
                }
                grid.Add(row);
            }
            return grid;

        }
    }
}