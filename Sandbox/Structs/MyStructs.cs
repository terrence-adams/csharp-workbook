using System;
using System.Windows;
using System.Drawing;

namespace Structs
{
   public struct pointStruct
    {
        static public int x ;
        static public int y;

        public pointStruct(int myX, int myY)
        {
            pointStruct.x = myX;
            pointStruct.y = myY;


        }


    }



    public class MyPoint
    {
        Point point1 = new Point(3, 5);
        Point point2 = new Point(4 , 3);

       pointStruct myPS = new pointStruct(5,5);


    }
}