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

            //int result = CheckRow(grid);
            int result2 = CheckDiagonalStartingleft(grid);
            if (result2 < 4)
            {
                result2 = CheckingColumn(grid);
            }


            return AreYouWinning(result2);


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
                        Console.WriteLine("testing");
                    }
                    else if (checking[b] == 1)
                    {
                        playerscore++;

                        Console.WriteLine("this is dispaying a one position");

                    }
                    else if (checking[b] == 2)
                    {
                        playerscore++;
                        Console.WriteLine("This is desplaying a two positions");
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
                    else
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



            return playerScore;

        }



    }

}



