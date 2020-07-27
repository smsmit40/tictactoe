using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoev2
{
    class Player_Y: Player_X
    {
        new public static string type = "O";

        new public static bool isUsed(string[] rowOne, string[] rowTwo, string[] rowThree)
        {
            

            if (row == 1 & rowOne[col] == "_")
            {
                rowOne[col] = Player_Y.type;
                return true;
            }
            else if (row == 2 & rowTwo[col] == "_")
            {
                rowTwo[col] = Player_Y.type;
                return true;
            }
            else if (row == 3 & rowThree[col] == "_")
            {
                rowThree[col] = Player_Y.type;
                return true;
            }
            else
            {
                Console.WriteLine("This spot has already been taken.");
                return false;
            }
        }
    }
}
