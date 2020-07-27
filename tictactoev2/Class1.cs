using System;
using System.Collections.Generic;
using System.Text;

namespace tictactoev2
{
    class Player_X
    {
        public static int row;
        public static int col;
        public static string type = "X";

        public static void FindRow()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the row you would like to use.");
                    row = Int32.Parse(Console.ReadLine());
                    if (row >= 1 & row <= 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid row");
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid row.");
                }

            }
        }
        public static void FindCol()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the row you would like to use.");
                    col = Int32.Parse(Console.ReadLine());
                    col -= 1;
                    if (col >= 0 & col <= 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid row");
                    }
                }

                catch (Exception f)
                {
                    Console.WriteLine("Please enter a valid column.");
                }
            }
        }

        public static bool isUsed(string[] rowOne, string[] rowTwo, string[] rowThree)
        {
            if (row == 1 & rowOne[col] == "_")
            {
                rowOne[col] = Player_X.type;
                return true;
            }
            else if (row == 2 & rowTwo[col] == "_")
            {
                rowTwo[col] = Player_X.type;
                return true;
            }
            else if (row == 3 & rowThree[col] == "_")
            {
                rowThree[col] = Player_X.type;
                return true;
            }
            else
            {
                Console.WriteLine("This spot has already been taken.");
                return false;
            }
        }

        public static void RowandCol()
        {

            Player_X.FindRow();
            Player_X.FindCol();
            Console.WriteLine($"You are Player {Player_X.type}");
        }
        
        public static bool DidWin(string[] rowOne, string[] rowTwo, string[] rowThree)
        {
            if (rowOne[0]== rowOne[1] & rowOne[0]==rowOne[2] & rowOne[0]==type)
            {
                Console.WriteLine($"Player {type} has won!");
                return true;
            }
            else if (rowTwo[0] == rowTwo[1] & rowTwo[0] == rowTwo[2] & rowTwo[0] == type)
            {
                Console.WriteLine($"Player {type} has won!");
                return true;
            }
            else if (rowThree[0] == rowThree[1] & rowThree[0] == rowThree[2] & rowThree[0] == type)
            {
                Console.WriteLine($"Player {type} has won!");
                return true;
            }
            else if (rowOne[0] == rowOne[1] & rowOne[0] == rowOne[2] & rowOne[0] == type)
            {
                Console.WriteLine($"Player {type} has won!");
                return true;
            }
            else if (rowOne[0] == rowTwo[1] & rowOne[0] == rowThree[2] & rowOne[0] == type)
            {
                Console.WriteLine($"Player {type} has won!");
                return true;
            }
            else if (rowThree[0] == rowTwo[1] & rowThree[0] == rowOne[2] & rowThree[0] == type)
            {
                Console.WriteLine($"Player {type} has won!");
                return true;
            }
            else if (rowOne[0] == rowTwo[0] & rowOne[0] == rowThree[0] & rowOne[0] == type)
            {
                Console.WriteLine($"Player {type} has won!");
                return true;
            }
            else if (rowOne[1] == rowTwo[1] & rowOne[1] == rowThree[1] & rowOne[1] == type)
            {
                Console.WriteLine($"Player {type} has won!");
                return true;
            }
            else if (rowOne[2] == rowTwo[2] & rowOne[2] == rowThree[2] & rowOne[2] == type)
            {
                Console.WriteLine($"Player {type} has won!");
                return true;
            }
            return false;
        }


    }

    
}
