using System;
namespace Cars
{
    public class Car
    {
        public Person [] people;
        int count = 0;
        int carCapacity = 4;
       
        public Car(string initialColor, int carCap)
        {
            carCapacity = carCap;
            Color = initialColor;
            this.people = new Person[carCapacity];
        }


        public void addPerson(Person p)
        {
           if(this.count <= this.carCapacity)
           {
            this.people[this.count] = p;
            this.count ++;
           }

           else
           {
               Console.WriteLine("The car is full!");
           }

        }

        public string Color { get; set; }



    }
}