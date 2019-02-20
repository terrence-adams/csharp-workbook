using System;
using System.Collections.Generic;

namespace CarLot

{
    class CarLot
    {

        public string name = "";
        List<Vehicle> carsOnLot = new List<Vehicle> ();
        
        public CarLot(string myName)
        {
            this.name = myName;
        }

        // adds obj of Vehicle type to default CarLot class List
        public void addVehicleToLot(Vehicle myVehicle)
        {
            carsOnLot.Add(myVehicle);

        }
        // iterates through the vehicles at the lot
        public void carLotInventory()
        {
            Console.WriteLine("There are {0} on the lot.",carsOnLot.Count);
            foreach(Vehicle v in carsOnLot)
            {
                v.printDetails();
                Console.WriteLine("");

            }

        }


    }






}