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
        public WinningConditionLogic gameLogic;

        public GameBoard(int height, int width)
        {
            heightGrid = height;
            widthGrid = width;
            positions = GridBuilding();
            gameLogic = new WinningConditionLogic();

        }


        public int GetWidthGrid()
        {
            return widthGrid;
        }

        public int GetHeightGrid()
        {
            return heightGrid;
        }


        private List<List<int>> GridBuilding()
        {

            List<List<int>> grid = new List<List<int>>();

            for (int x = 0; x < heightGrid; x++)
            {
                List<int> row = new List<int>();
                for (int y = 0; y < widthGrid; y++)
                {
                    row.Add(0);
                }
                grid.Add(row);
            }
            return grid;

        }

        public void playmove(int column, int player)
        {
            int counter = 0;
            while (counter < this.heightGrid)
            {
                if (this.positions[counter][column] == 0)

                {
                    if (player == 1)
                    {
                        this.positions[counter][column] = 1;
                        break;
                    }
                    else
                    {
                        this.positions[counter][column] = 2;
                        break;
                    }
                }
                else
                {
                    counter++;

                }
            }
        }
    }
}