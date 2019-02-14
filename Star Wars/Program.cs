using System;

namespace StarWars
{
    public class Program
    {
        public static void Main()
        {
            Person leia = new Person("Leia", "Organa", "Rebel");
            Person luke = new Person("Luke", "Skywalker", "Rebel");
            Person han = new Person("Han", "Solo", "Rebel");
            Person darth = new Person("Darth", "Vader", "Imperial");
            Person palpatine = new Person("Emperor", "Palpatine", "Imperial");
            Ship falcon = new Ship("Rebel", "Smuggling", 2, "Millenium Falcon");
            Ship tie = new Ship("Tie", "Fighter", 1, "Fighter1");
            Ship xWing = new Ship("X-Wing","Fighter", 1, "X-Winger1");
            Station rebel = new Station("Rebel Space Station", "Rebel", 20);
            Station empire = new Station("Deathstar", "Imperial", 50);

            falcon.EnterShip(leia,0);
            falcon.EnterShip(luke,1);
            rebel.dockShip(falcon, 2);
           string myPass1 = rebel.Roster;
           Console.WriteLine(myPass1);
        

        }
    }

    public class Person
    {
        private string firstName;
        private string lastName;
        private string alliance;
        public Person(string firstName, string lastName, string alliance)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.alliance = alliance;
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }

            set
            {
                string[] names = value.Split(' ');
                this.firstName = names[0];
                this.lastName = names[1];
            }
        }
    }

    public class Ship
    {
        private Person[] passengers;
        public Ship(string alliance, string type, int size, string myName)
        {
            this.Type = type;
            this.Alliance = alliance;
            this.passengers = new Person[size];
            this.Name = myName;
        }

        public string Type
        {
            get;
            set;
        }

        public string Alliance
        {
            get;
            set;
        }
        public string Name 
        {
            get;
            set;
        }

        public string Passengers
        {
            get
            {
                foreach (var person in passengers)
                {
                    Console.WriteLine(String.Format("{0}", person.FullName));
                }

                return "That's Everybody!";
            }
        }

        public void EnterShip(Person person, int seat)
        {
            this.passengers[seat] = person;
        }

        public void ExitShip(int seat)
        {
            this.passengers[seat] = null;
        }
    }

    public class Station
{
        bool empty = true;
        public string stationName = "";
        string stationAlliance = "";
        public static int sizeOfStation = 10;

        Ship [] dockArray = new Ship [sizeOfStation];
        
        public string Roster
        {
            get
            {
               
                foreach (Ship S in dockArray)
                {
                    if(S != null)
                    {
                        Console.WriteLine(S.Type);
                        Console.WriteLine(S.Passengers);
                    }

                    
                }

                return "These are the passengers.";
            } 


        }
        public Station(string myStationName, string myStationAlliance, int mySize )
        {
            this.dockArray = new Ship [mySize];
            this.stationAlliance = myStationAlliance;
            this.stationName = myStationName;

        }

       
        public void dockShip(Ship s, int myPort)
        {
            if(checkPort(myPort))
            {
                dockArray[myPort] = s;

            }

            else
            {
                Console.WriteLine("This port is not empty.");
            }



        }

        public void unDockShip(Ship s, int myPort)
        {

            if(!checkPort(myPort))
            {

                dockArray[myPort] = null;

            }

            else
            {
                Console.WriteLine("There is no ship in this port.");
            }


        }

        private bool checkPort(int index)
        {
            if(dockArray[index] != null)
            {

                this.empty = false;
                return this.empty;

            }

            else
            {
                return this.empty;
            }
            
            

        }

        private void setPortBackToEmpty()
        {
            this.empty = true;

        }





    }
}