using System;

namespace Checkers
{

    public class Checker
    {
        public string Symbol  { get; set; }
        public int[] Position  { get; set; }
        public string Color { get; set; }
        
        public Checker(string color, int[] position)
        {
            this.Color = color.ToLower();
            this.Position = position;

            if(this.Color != null || this.Color != "")
            {
                if(this.Color == "white")
                {
                    createWhiteChecker();

                }

                else
                {
                    createBlackChecker();

                }
            }
        }

        //generates the desired symbol using utf32
        private string whiteChecker()
        {
            int openCircleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
            string openCircle = char.ConvertFromUtf32(openCircleId);
            return openCircle;

        }

            //generates the desired symbol using utf32
        private string blackChecker()
        {
            int closedCircleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
            string closedCircle = char.ConvertFromUtf32(closedCircleId);
            return closedCircle;

        }

        // sets the symbol for the checker instance
        public void createWhiteChecker()
        {
            this.Symbol = whiteChecker();

        }

        //sets the symbol for this checker instance
        public void createBlackChecker()
        {

            this.Symbol = blackChecker();

        }


    }









}