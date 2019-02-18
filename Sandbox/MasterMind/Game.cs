using System.Linq;
using System;
using System.Collections.Generic;


namespace MasterMind
{
    class Game
    {
       
        private List<Row> rows = new List<Row> ();
        private string[] answer = new string[4];

        private int _turns = 4;
        int winningScore = 4;
        bool youWon = false;

        public Game ( int turns )
        {
            randomAnswerGenerator();
            this._turns = turns;
        }

        private string Score (Row row) {
            string[] answerCopy = (string[]) this.answer.Clone ();
            // red is correct letter and correct position
            // white is correct letters minus red
            // this.answer => ["a", "b", "c", "d"]
            // row.balls => [{ Letter: "c" }, { Letter: "b" }, { Letter: "d" }, { Letter: "a" }]
            
            int red = 0;

            for (int i = 0; i < 4; i++) {
                if (answerCopy[i] == row.balls[i].Letter) 
                {
                    red++;
                }
            }

            int white = 0;
            for (int i = 0; i < 4; i++) {
                int foundIndex = Array.IndexOf (answerCopy, row.balls[i].Letter);
                if (foundIndex > -1) {
                    white++;
                    answerCopy[foundIndex] = null;
                }
            }
            if(red -(white-red) == winningScore)
            {
                youWon = true;
            }

            return $"{red} matching and {white} in the solution.";


        }

        public void AddRow (Row row) {
            this.rows.Add (row);
        }

        public void playGame()
        {

            for (int turns = this._turns; turns > 0; turns--) 
            {
                Console.WriteLine($"You have {turns} tries left");
                seeAnswer();
                Console.WriteLine ("Choose four letters: a,b,c,d,e,f,g");
                try
                {

                    string letters = Console.ReadLine();
                    Ball[] balls = new Ball[4];

                    for (int i = 0; i < 4; i++) 
                    {
                        balls[i] = new Ball (letters[i].ToString().ToLower());
                    }
                    
                    Row row = new Row (balls);
                    AddRow (row);
                    Console.WriteLine (Rows);

                    if(youWon)
                    {
                        break;
                    }
                }
                catch
                {
                    throw new ApplicationException("Failed to execute as expected.");
                }
            }
            if(youWon)
            {
                Console.WriteLine("Press Enter to Exit.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine ("Out Of Turns");
            }

        }
 
        public string Rows {
            get {
                foreach (var row in this.rows) {
                    Console.WriteLine(row.Balls);
                    checkForWinner(row);
                }
                return "";
                
            }
        } 

        private void checkForWinner(Row myRow)
        {   
            string myScore = Score(myRow);

            if(youWon)
            {
                Console.WriteLine("Your matched all 4, you have won the game!");
            }
            else{
                Console.WriteLine("{0}.",myScore);
            }
        }

         private void randomAnswerGenerator()
        {
            string [] possibleAnswers = new string[]{"a","b","c","d","e","f","g"};
            int [] indexArray = new int[20];
            Random rdm = new Random();
            int possibleBalls = 4;

            for(int i = 0; i < 20 ; i ++)
            {
                indexArray[i] = rdm.Next(0,7);
            }

            var uniqueIndex = new HashSet<int>(indexArray); // removes duplicates

            int [] uniqueIndexArray = uniqueIndex.ToArray();

            if(uniqueIndexArray.Length >= possibleBalls)
            {
                for(int j = 0; j < possibleBalls; j++)
                {
                    this.answer[j] = possibleAnswers[uniqueIndexArray[j]];

                }
            }

            else
            {
                throw new ApplicationException ("Unable to create random answer.");
            }
           

        }

        private void seeAnswer()
        {
            foreach(string s in this.answer)
            {
                Console.Write(s);
            }
            Console.WriteLine("\n");

        }

    }
}


