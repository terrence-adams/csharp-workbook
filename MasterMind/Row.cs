using System;
using System.Collections.Generic;

namespace MasterMind
{
    class Row
    {
        public Ball[] balls = new Ball[4];

        public Row (Ball[] balls) {
            this.balls = balls;
        }

        public string Balls {
            get {
                foreach (var ball in this.balls) {
                    Console.Write (ball.Letter);
                }
                return "";
            }
        }
    }
}
