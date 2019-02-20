using System;

namespace CarLot
{


    public abstract class Vehicle
    {

        public string licenseNumber ;
        public string vehicleMake;
        public string vehicleModel;
        public float vehiclePrice;
        public string vehicleDescription;

        // base class method to provide details about all the vehicles
        virtual public void printDetails()
        {
            Console.WriteLine("Vehicle Description: {0}",this.vehicleDescription);
            Console.WriteLine("License number : {0}",this.licenseNumber);
            Console.WriteLine("Vehicle make : {0}",this.vehicleMake);
            Console.WriteLine("Vehicle model : {0}", this.vehicleModel);
            Console.WriteLine("The price of of the vehicle is ${0}",this.vehiclePrice);


        }



    }



}