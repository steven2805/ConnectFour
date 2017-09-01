using System;
using System.Collections.Generic;

namespace ConnectFour

{
    public class WinningConditionLogic
    {


        public WinningConditionLogic()
        {

        }

        public Boolean ConditionChecker(List<List<int>> grid)
        {

            CheckRow(grid);
            return false;
        }

        private Boolean AreYouWinning(int score)
        {
            if (score == 4)
            {
                return true;
            }
            return false;
        }


        // Checking row is done by checking the entire row from left to right
        private void CheckRow(List<List<int>> grid){

			for (int a = 0; a < grid.Count; a++)
			{
				Console.WriteLine("value of a: {0}", a);
                var checking = grid[a];

                for (int b = 0; b < grid[0].Count;b++){
                    if(checking[b] == 0){
                        Console.WriteLine("testing");
                    }
                }
			}


        }
    


    }



}



