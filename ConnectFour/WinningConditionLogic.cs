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
            AreYouWinning(result);
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
        private int CheckRow(List<List<int>> grid)
        {
            int playerscore = 0;
            for (int a = 0; a < grid.Count; a++)
            {
                var checking = grid[a];

                for (int b = 0; b < grid[0].Count; b++)
                {
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

        //private void CheckingColumn(List<List>)
        //{

        //}



    }



}



