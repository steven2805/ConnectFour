using System;
using System.Collections;

namespace ConnectFour
{
    public class GameBoard
    {
        public ArrayList testing;
        private int heightGrid;
        private int widthGrid;


        public GameBoard(int height, int width)
        {
            testing = GridBuilding();
            heightGrid = height;
            widthGrid = width;
        }

        public int GetLengthGrid(){
            return heightGrid;
        }

        private ArrayList GridBuilding(){
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");


            return myAL;
        }
 


    }
}
