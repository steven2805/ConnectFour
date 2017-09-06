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
            int result = CheckRow(grid);
            if(CheckRow(grid) == 4 ){
                return true;
            }
            else if(CheckingColumn(grid) == 4){
                return true;
            }
            else if(CheckDiagonalStartingleft(grid) == 4){
                return true;
            }
            else{
                return true;
            }

        }

     


        // Checking row is done by checking the entire row from left to right
        private int CheckRow(List<List<int>> grid)
        {
            int playerscore = 0;
            for (int a = 0; a < grid.Count; a++)
            {
                var checking = grid[a];

                for (int b = 0; b < grid[0].Count; b++)
                {
                    if (playerscore >= 4)
                    {
                        break;
                    }
                    if (checking[b] == 0)
                    {
                        playerscore = 0;
                    }
                    else if (checking[b] == 1)
                    {
                        playerscore++;

                    }
                    else if (checking[b] == 3)
                    {
                        playerscore++;
                    }
                }
            }
            return playerscore;


        }

        private int CheckingColumn(List<List<int>> grid)
        {
            int playerScore = 0;

            for (int a = 0; a < grid[0].Count; a++)
            {
                var checking = a;

                for (int b = 0; b < grid.Count; b++)
                {
                    if (playerScore >= 4)
                    {
                        break;
                    }
                    if (grid[b][checking] == 0)
                    {
                        playerScore = 0;
                    }
                    else if(grid[b][checking] == 1)
                    {
                        playerScore++;
                    }
                }
            }
            return playerScore;

        }

        private int CheckDiagonalStartingleft(List<List<int>> grid)
        {
            int playerScore = 0;

            for (int a = 0; a < grid.Count; a++)
            {

                int counterX = grid[0].Count;
                int counterY = a;
                int counter = 0;

                while (counter < grid[0].Count)
                {
                    if (counterY < 0)
                    {
                        playerScore = 0;
                        break;
                    }
                    else
                    {
                        if (grid[counterY][counter] == 1)
                        {
                            playerScore++;
                        }
                        else
                        {
                            playerScore = 0;
                        }

                    }
                    counterY--;
                    counter++;


                }

            }
            if (playerScore >= 4)
            {
                return playerScore;

            }
            else
            {

                int setCounter = grid.Count;
                int playerScore2 = 0;


                for (int a = 0; a < grid[0].Count; a++)
                {
                    int columnCounter = a;
                    int rowCounter = setCounter;
                    rowCounter--;

                   

                    if (playerScore2 == 4)
                    {
                        return playerScore2;
                    }

                    while (columnCounter < grid[0].Count)
                    {



                        if (grid[rowCounter][columnCounter] == 1)
                        {
                            playerScore2++;
                            if (playerScore2 == 4)
                            {
                                break;
                            }
                        }
                        else
                        {
                            playerScore2 = 0;
                        }
                        rowCounter--;
                        columnCounter++;
                    }
                }
                return playerScore2;
            }
        }



    }

}












