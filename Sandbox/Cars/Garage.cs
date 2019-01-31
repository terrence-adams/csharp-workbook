using System;

namespace Cars
{
    public class Garage
        {   
            public Car[] cars;

            public Garage(int initialSize)
            {
                Size = initialSize;
                this.cars = new Car[initialSize];
            }

            public int Size { get; private set; }

            public void ParkCar ( Car car, int spot)
            {
                cars[spot] = car;
            }

            public string Cars {
            get {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null) {
                Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
                for(int j = 0; j < cars[i].people.Length; j++)
                    {
                        Console.WriteLine("{0} is in the car", cars[i].people[j].name) ;
                        
                    }
                }
            }
            return "That's all!";
            }
        }
    }
}