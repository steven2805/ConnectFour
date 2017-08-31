using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConnectFour
{
    public class GameBoard
    {

        private int heightGrid;
        private int widthGrid;
        private List<List<int>> positions;




        public GameBoard(int height, int width)
        {
            heightGrid = height;
            widthGrid = width;
            positions = GridBuilding();


        }

        public int GetLengthGrid()
        {
            return heightGrid;
        }



        private List<List<int>> GridBuilding()
        {


            //List.get(x).getCell(y);
            //List.get(x+1).getCell(y);
            //List.get(x-1).getCell(y);
            //List.get(x).getCell(y+1);
            //Board.getRow(x+1).getCellValue(y+1); 0,1,2

            //List.get(16)

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