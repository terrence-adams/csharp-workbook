using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            string parkedCars = "";
            Person david = new Person("David");
            Person terry = new Person("Terry");
            Person dennis = new Person("Dennis");

            Car myCar1 = new Car("blue", 3);
            myCar1.addPerson(david);
            myCar1.addPerson(terry);
            myCar1.addPerson(dennis);

            Garage myGarage1 = new Garage(6);
            myGarage1.ParkCar(myCar1, 1);
            parkedCars = myGarage1.Cars;


        }
    }
}
