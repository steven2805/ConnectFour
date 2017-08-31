using System;
using System.Collections.Generic;

namespace ConnectFour

{
    public class GameLogic
    {
        

        public GameLogic()
        {

        }

        public Boolean ConditionChecker(int[] playerposition,List<List<int>> grid){
            int row;

            row = playerposition[0];
            CheckRow(row, grid);
            return false;
        }

        private Boolean AreYouWinning(int score){
            if(score == 4){
                return true;
            }
            return false;
        }

		private void CheckRow(int row, List<List<int>> grid)
		{
            List<int> checkingRow = new List<int>();

            checkingRow = grid[row];
            int playerOneScore = 0;
            int playerTwoScore = 0;
            int counter = 0;
            while (counter < checkingRow.Count){
                if(checkingRow[counter] == 1){
                    playerOneScore++;
                    AreYouWinning(playerOneScore);
                    counter++;
                }
                else if (checkingRow[counter] == 2){
                    playerTwoScore++;
                    AreYouWinning(playerTwoScore);
                    counter++;
                }
                else{
                    playerTwoScore = 0;
                    playerOneScore = 0;
                    counter++;
                }

            }
		}
    }

   
}



