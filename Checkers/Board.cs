using System;
using System.Collections.Generic;
using System.Linq;


namespace Checkers
{
    public class Board
    {
        public string[][] Grid  { get; set; }
        public List<Checker> Checkers { get; set; }
        
        public Board()
        {
            this.Checkers = new List<Checker> ();
            this.Grid = new string[8][] ;
           
           
        }
        
        // Generates the board
        public void CreateBoard()
        {
            
            Console.Write(" 0 1 2 3 4 5 6 7");
            for(int i = 0 ; i < 8 ; i++)
            {
                this.Grid[i] = new string [8];
                

                for(int j = 0; j < 8; j++)
                {   
                    this.Grid[i][j] = " ";
                    Console.Write(this.Grid[i][j]);
                }
                

            }

            Console.WriteLine(""); // moves to next line for display

        }
        
        //generates list of checkers with coordinates
        public void GenerateCheckers()
        
        {
                List <int[]> whitePositions = new List<int[]>
                {
                    new int [] {0,1},
                    new int [] {0,3},
                    new int [] {0,5},
                    new int [] {0,7},
                    new int [] {1,0},
                    new int [] {1,2},
                    new int [] {1,4},
                    new int [] {1,6},
                    new int [] {2,1},
                    new int [] {2,3},
                    new int [] {2,5},
                    new int [] {2,7},
                } ;     
            List <int []> blackPositions = new List<int[]> 
            {
                    new int [] {5,0},
                    new int [] {5,2},
                    new int [] {5,4},
                    new int [] {5,6},
                    new int [] {6,1},
                    new int [] {6,3},
                    new int [] {6,5},
                    new int [] {6,7},
                    new int [] {7,0},
                    new int [] {7,2},
                    new int [] {7,4},
                    new int [] {7,6},
            };

            for(int i = 0; i < whitePositions.Count; i++)
            {

                Checkers.Add(new Checker("white", whitePositions[i]));

            }

             for(int i = 0; i < blackPositions.Count; i++)
            {
                Checkers.Add(new Checker("black", blackPositions[i]));
            }

            //validates existence of checkers in collection
            // foreach(Checker c in Checkers)
            // {
            //     Console.WriteLine(c.Symbol);
            // }
   
        }
        
        // places the checkers on the grid from the List
        public void PlaceCheckers()
        {
            for (var i = 0; i < Checkers.Count; i++)
            {
                int[] position = Checkers[i].Position;
                this.Grid[position[0]][position[1]] = Checkers[i].Symbol;
            }
        }


        
        
        //draws the board based on position of checkers with a virtual board from a jagged array
        public void DrawBoard()
        {
            CreateBoard();
            GenerateCheckers();
            PlaceCheckers();
            

            for(int i = 0 ; i < 8 ; i++)
            {
                Console.Write(i.ToString());
                for(int j = 0; j < 8; j++)
                {
                    Console.Write( "|" + this.Grid[i][j]);
                }
                Console.Write("|");
                Console.WriteLine("\r");              

            }
            
        }

        // used to refresh board after moves/removes
        public void reloadBoard()
        {
            CreateBoard();
            PlaceCheckers();
            for(int i = 0 ; i < 8 ; i++)
            {
                Console.Write(i.ToString());
                for(int j = 0; j < 8; j++)
                {
                    Console.Write( "|" + this.Grid[i][j]);
                }
                Console.Write("|");
                Console.WriteLine("\r");
                
            }

        }
        
        // used to return checker class object found based on coordinates
        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }


        // main method invoked for input and moving checkers no board
        public void moveCheckerOnBoard()
        {

            int oldRow = 0;
            int oldColumn = 0;
            int newRow = 0;
            int newColumn = 0;
        

            Console.WriteLine("Enter pick up row.");
            //oldRow = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out oldRow);
            Console.WriteLine("Enter pick up column.");
            int.TryParse(Console.ReadLine(), out oldColumn);
            //oldColumn = int.Parse(Console.ReadLine());
            
            

            Console.WriteLine("Enter placement row.");
            //newRow = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out newRow);
            Console.WriteLine("Enter placement column.");
            //newColumn = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out newColumn);

            if(oldRow < 8 && oldColumn < 8 && newRow < 8 && newColumn < 8 )
            {
                moveChecker(oldRow, oldColumn, newRow, newColumn);
                reloadBoard();
            }

            else
            {
                Console.WriteLine("Invalid values.");
            }
           
            

        }

        // method called to move checker from prior position
        public void moveChecker(int oldR, int oldC, int newR, int newC)
        {
            int oldRow = oldR;
            int oldColumn = oldC;
            int newRow = newR;
            int newColumn = newC;
            Checker checkerMoved ;
            Checker placedChecker ;


            checkerMoved = SelectChecker(oldRow, oldColumn);
            placedChecker = SelectChecker(newRow,newColumn);

            //checks to make sure it is a valid checker and a valid move
            if(Checkers.Contains(checkerMoved) && !Checkers.Contains(placedChecker) && newRow < 8 && newColumn < 8)
            {
                int [] newPosition = new int[]{ newRow, newColumn};
                checkerMoved.Position = newPosition;
                RemoveChecker(oldRow, oldColumn);
            }
            else
            {
                Console.WriteLine("Invalid move attempted.");

            }

            

        }

        // method invoked to get input and remove checker from the board
        public void removeCheckerFromBoard()
        {
            int oldRow = 0;
            int oldColumn = 0;
            Checker validationChecker;

            Console.WriteLine("Enter row to remove.");
            int.TryParse(Console.ReadLine(), out oldRow);
            Console.WriteLine("Enter column to remove.");
            int.TryParse(Console.ReadLine(), out oldColumn);
            validationChecker = SelectChecker(oldRow, oldColumn);
            
           

            if(Checkers.Contains(validationChecker))
            {
                RemoveChecker(oldRow,oldColumn);
                reloadBoard();
            }
            else
            {
                Console.WriteLine("Invalid move attempted.");

            }
            


        }

        //finds checker passed in and removes it from the list of board checkers
        
        public void RemoveChecker(int row, int column)
        {
            Checker removedChecker ;
            removedChecker = SelectChecker(row, column);
            Checkers.Remove(removedChecker); //removes the checker object that was returned at that location provided
        }
        
        public bool CheckForWin()
        {
            if(Checkers.All(x => x.Color == "white"))
            {
                Console.WriteLine("The white player has won.");
            }

            else if(!Checkers.Exists(x => x.Color == "white"))
            {
                Console.WriteLine("The black player has won.");
            }
            
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }

        public void forceWin()
        {
            //Checker myChecker = new Checker("black", new int [] {9,9}); used to test forced win
            foreach(Checker c in this.Checkers)
            {
                c.Color = "black";
                //c.Symbol = myChecker.blackChecker(); used for testing. set Blackchecker method to public
            }
            
            //reloadBoard(); used for testing a forced win.

        }
    }










    
}