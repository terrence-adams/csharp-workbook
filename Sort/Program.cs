using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] myArray = {2,33,45,12,456,23,22,90,0,100};

            Program.myBubbleSort(myArray);


        } 


        static public void myBubbleSort(int [] array1)
        {
                       
            int[] myArray = new int [array1.Length];
            myArray = array1;
            int temp = 0;

            for(int i = 0 ; i < myArray.Length -1 ; i++)
                for( int j = 0; j < myArray.Length -1; j++)
                    if(myArray[j] > myArray[j+1])
                    {
                        temp = myArray[j+1];
                        myArray[j+1] = myArray[j];
                        myArray[j] = temp;

                    }



            foreach(int i in myArray)
            {
                Console.WriteLine(i.ToString());

            }


        }
    }
}
