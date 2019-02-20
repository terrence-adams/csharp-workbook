using System;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car myCar = new Car("Brand New 2020","ASZ452","Chevy", "Nova", "Coupe", 2, 35000.00f);
            Car myCar2 = new Car("Family Car 2019","ABC452","Ford", "Fusion", "Sedan", 4, 25000.00f);
            Car myCar3 = new Car("Hot Deal 2018","WSD333","Chevy", "Corvette", "Coupe", 2, 44000.00f);
            Car myCar4 = new Car("It's a steal 2019","A2DD32","Dodge", "Charger", "Sedan", 4, 27000.00f);


            Truck myTruck = new Truck("Big Wheels","SDF2233", "Dodge", "Ram", 15.00m, 34999.00f);
            Truck myTruck2 = new Truck("Reliable","SDA2313", "Toyota", "Tundra", 12.00m, 24999.00f);
            Truck myTruck3 = new Truck("SuperSport","ASD12SD", "Ford", "F-150", 14.00m, 54999.00f);
            Truck myTruck4 = new Truck("WorkHorse","A11D3E", "Dodge", "Ram", 15.00m, 44999.00f);

            CarLot carLotA = new CarLot("Bob's Bonaza");
            CarLot carLotB = new CarLot("Terry's Terrific Trade-Ins!");


            carLotA.addVehicleToLot(myCar);
            carLotA.addVehicleToLot(myCar3);
            carLotA.addVehicleToLot(myTruck);
            carLotA.addVehicleToLot(myTruck2);

            carLotB.addVehicleToLot(myCar2);
            carLotB.addVehicleToLot(myCar4);
            carLotB.addVehicleToLot(myTruck3);
            carLotB.addVehicleToLot(myTruck4);

            Console.WriteLine("{0} has these vehicles.", carLotA.name);
            carLotA.carLotInventory();
            Console.WriteLine("");
            Console.WriteLine("{0} has these vehicles.", carLotB.name);
            carLotB.carLotInventory();
        }
    }
}
