using System;
using System.Windows;
using System.Drawing;

namespace Structs
{
   public struct pointStruct
    {
        public int x;
        public int y;

        public pointStruct(int myX, int myY)
        {
            x = myX;
            y = myY;


        }


    }



    public class MyPoint
    {
        Point point1 = new Point(3, 5);
        Point point2 = new Point(4 , 3);

       pointStruct myPS = new pointStruct(5,5);

       

      

            


    }
}