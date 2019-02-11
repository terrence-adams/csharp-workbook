using System;
using System.Collections.Generic;


namespace OOPS1
{

    public class Warehouse
    {
        public List <Container> _whContainers = new List<Container>();
        public string name 
        {
            get;
            set;
        }

        
      



         public Warehouse ()
        {
           string default1 = "Austin-00";
           this._whContainers =  new List<Container>{ new Container ( default1)}; 
           this.name = "Austin";
           
           
        }

        public Warehouse (string my_name)
        {
           this._whContainers =  new List<Container>{ new Container ( my_name)}; 
           this.name = my_name;

        }


        public Warehouse( List <Container> myContainers, string my_name)
        {
           this._whContainers = myContainers;
           this.name = my_name;

        }




        public void addContainerToWH(Container a )
        {

            this._whContainers.Add(a);


        }

        public void addMultipleContainersToWH(List <Container> myContainers)
        {

            foreach(Container c in myContainers)
            {

                this._whContainers.Add(c);

            }


        }


        


    }

}