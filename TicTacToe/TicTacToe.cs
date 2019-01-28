using System;

namespace TicTacToe
{
    class Program
    {
        public static string x = "x";
        public static string y = "y";
        public static int row = 0;
        public static int column = 0;

        public static bool gameWon = false;

        public static string playerTurn = "x";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();
                placeMarkForPlayer();
                

            } while (!CheckForWin() && !CheckForTie());

            
            Console.WriteLine("Press Enter to end.");

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            column = int.Parse(Console.ReadLine());
            


        }

        public static void placeMarkForPlayer()
        {
            
            PlaceMark();
            if(CheckForWin())
            {
                printWinner();
            }

            else
            {
                setTogglePlayerTurn();
            }
            


        }


        public static void setTogglePlayerTurn()
        {
           playerTurn = (playerTurn == x) ? y : x;

        }

      
        public static void PlaceMark()
        {   
            if(row <= 2 && column <=2)
            {
                board[row][column] = playerTurn;
            }

            else
            {
                throw new System.ArgumentException("Out of range value.");
            }
            
        }

        public static void printWinner()
        {
            Console.WriteLine("Player {0}", playerTurn + " Won!!! ");

        }

        public static bool CheckForWin()
        {
            
            if(HorizontalWin() || VerticalWin () || DiagonalWin() )
            {
                gameWon = true;
                return gameWon;
                
               
            }

            else
            {
             return gameWon;  
            }

            
        }

        public static bool CheckForTie()
        {

            return gameWon;
        }
        
        public static bool HorizontalWin()
        {
        bool win = false;

        for(int i = 0; i < 3; i++)
        {
            if(board[i][0] == playerTurn && board[i][1] == playerTurn && board[i][2] == playerTurn)
            {
                win = true;
                return win;
                
            }

        }


        return win;
        }

        public static bool VerticalWin()
        {
            bool win = false;

            
        for(int i = 0; i < 3; i++)
        {
            if(board[0][i] == playerTurn && board[1][i] == playerTurn && board[2][i] == playerTurn)
            {
                win = true;
                return win;
                
            }

        }

            return win;
        }

        public static bool DiagonalWin()
        {
            bool win = false;

            if(board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2]== playerTurn)
            {
                win = true;
                return win;

            }

             else if(board[2][0] == playerTurn && board[1][1] == playerTurn && board[0][2]== playerTurn)
            {
                win = true;
                return win;

            }
            

            return win;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
