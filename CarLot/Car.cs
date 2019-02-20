using System;

namespace CarLot

{

    class Car:Vehicle
    {
        int numberOfDoors = 4;
        string vehicleType = "";

        //extended constructor
        public Car (string description, string license, string make, string model, string vType, int numbOfDoors, float vPrice)
        {
            this.vehicleDescription = description;
            this.licenseNumber = license;
            this.vehicleMake = make;
            this.vehicleModel = model;
            this.vehicleType = vType;
            this.numberOfDoors = numbOfDoors;
            this.vehiclePrice = vPrice;


        }

        //overriden property method to include car type
        override public void printDetails()
        {
            Console.WriteLine("Vehicle Description: {0}.",this.vehicleDescription);
            Console.WriteLine("The license number is {0}.",this.licenseNumber);
            Console.WriteLine("The vehicle make is a {0}.",this.vehicleMake);
            Console.WriteLine("The vehicle model is : {0}.", this.vehicleModel);
            Console.WriteLine("This is a {0} door {1}.", this.numberOfDoors, this.vehicleType);
            Console.WriteLine("The price of the vehicle is ${0}.",this.vehiclePrice);
            

        }


    }




    
}