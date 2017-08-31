using System;
using System.Collections.Generic;

namespace ConnectFour

{
    public class GameLogic
    {
        public GameLogic()
        {
            
        }

        public Boolean CheckingForWinning(int[] playerposition,List<List<int>> grid){
            List<int> row = new List<int>();

            row = grid[playerposition[0]];

            return false;
        }
    }
}
