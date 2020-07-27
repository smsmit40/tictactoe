using System;

namespace tictactoev2
{
    class Program
    {
        static string[] rowOne = new string[] { "_", "_", "_" };
        static string[] rowTwo = new string[] { "_", "_", "_" };
        static string[] rowThree = new string[] { "_", "_", "_" };
        static void Main(string[] args)
        {
            for (var i=1; i<=10; i++)
            {
                if (i%2 != 0)
                {
                    while (true)
                    {
                        Player_X.RowandCol();
                        if(Player_X.isUsed(rowOne, rowTwo, rowThree)==true)
                        {
                            
                            break;
                        }
                    }
                    if (Player_X.DidWin(rowOne, rowTwo, rowThree)==true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{rowOne[0]}{rowOne[1]}{rowOne[2]}\n{rowTwo[0]}{rowTwo[1]}{rowTwo[2]}\n{rowThree[0]}{rowThree[1]}{rowThree[2]}");
                        continue;
                    }
                    
                    
                }
                else {
                    while (true)
                    {
                        Player_Y.RowandCol();
                        if (Player_Y.isUsed(rowOne, rowTwo, rowThree) == true)
                        {
                            Console.WriteLine($"{rowOne[0]}{rowOne[1]}{rowOne[2]}\n{rowTwo[0]}{rowTwo[1]}{rowTwo[2]}\n{rowThree[0]}{rowThree[1]}{rowThree[2]}");
                            break;
                        }
                    }
                    if(Player_Y.DidWin(rowOne, rowTwo, rowThree)==true)
                    {
                        Console.WriteLine($"{rowOne[0]}{rowOne[1]}{rowOne[2]}\n{rowTwo[0]}{rowTwo[1]}{rowTwo[2]}\n{rowThree[0]}{rowThree[1]}{rowThree[2]}");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                   
                }
            }           
            
        }
    }
}
