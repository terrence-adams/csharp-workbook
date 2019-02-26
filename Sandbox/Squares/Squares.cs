using System;
using System.Collections.Generic;
using System.Collections;


namespace Squares 
{

    public class Squares
    
    {

        public int returnSquares ( IEnumerable <int> myCollection)
        {
            int sum = 0;

            foreach( int i in myCollection)
            {

                sum += (int)Math.Pow(i,2);

            }

            return sum;

        }


        public int manualSquare(int myVal)
        {

            return myVal * myVal;

        }
    }












}