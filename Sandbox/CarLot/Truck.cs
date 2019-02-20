using System;

namespace CarLot

{

    class Truck:Vehicle
    {
        decimal bedSize = 2.00m;

        //extended constructor
           public Truck (string description, string license, string make, string model, decimal bedSz, float vPrice)
        {
            this.vehicleDescription = description;
            this.licenseNumber = license;
            this.vehicleMake = make;
            this.vehicleModel = model;
            this.bedSize = bedSz;
            this.vehiclePrice = vPrice;


        }

        //extended method to display truck properties
          override public void printDetails()
        {
            Console.WriteLine("Vehicle Description: {0}",this.vehicleDescription);
            Console.WriteLine("License number : {0}.",this.licenseNumber);
            Console.WriteLine("Vehicle make : {0}",this.vehicleMake);
            Console.WriteLine("Vehicle model :{0}", this.vehicleModel);
            Console.WriteLine("This truck has a {0} meter bed", this.bedSize);
            Console.WriteLine("The price of the vehicle is ${0}",this.vehiclePrice);
            

        }



    }




    
}