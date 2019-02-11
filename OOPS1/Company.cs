using System;
using System.Collections.Generic;


namespace OOPS1
{

   public class Company
    {
        public List <Warehouse> _warehouses = new List<Warehouse>();
        public string name = "";

        public Company(string companyName)
        {
           this._warehouses = new List<Warehouse>{
           new Warehouse( )};
           this.name = companyName;

        }

        public Company(List <Warehouse> myWarehouses)
        {

            this._warehouses = myWarehouses;

        }


        public void addWarehousesToCompany(Warehouse w)
        {

            this._warehouses.Add(w);

        }



        public void addMultipleWarehousesToCompany(List <Warehouse> myWarehouses)
        {
            foreach(Warehouse w in myWarehouses)
            {
                this._warehouses.Add(w);
                

            }

        }


        public void buildCompany()
        {


            Container a1 = new Container("Austin-01");
            Container a2 = new Container("Austin-02");
            Container d1 = new Container("Dallas-01");
            Container d2 = new Container("Dallas-02");
            Container c1 = new Container("Colorado-01");
            Container L1 = new Container("LosAngeles-01");
            Container r1 = new Container("Reno-01");
            Container s0 = new Container("Seattle-00");

            List<Item> newItemsOnSale = new List <Item>{
                new Item(0.34m,"peach"), new Item(1.23m,"watermelon"), new Item(0.56m, "pear") };

            List<Item> newItemsOnSpecial = new List <Item>{
                new Item(0.34m,"lime"), new Item(1.23m,"orange"), new Item(0.56m, "tangerine") };
            


        
            Warehouse austin = new Warehouse(new List<Container>(){a1,a2}, "Austin");
            Warehouse dallas = new Warehouse(new List<Container>(){d1,d2}, "Dallas");
            Warehouse colorado = new Warehouse(new List<Container>(){c1}, "Colorado");
            Warehouse losAngeles = new Warehouse(new List<Container>(){L1}, "Los Angeles");
            Warehouse reno = new Warehouse(new List<Container>(){r1}, "Reno");
            Warehouse seattle = new Warehouse(new List<Container>(){s0}, "Seattle");

            List <Warehouse> myCompWarehouses = new List <Warehouse>{austin,dallas,colorado,losAngeles,reno,seattle};
            

            this.addMultipleWarehousesToCompany(myCompWarehouses);  
            //this.addWarehousesToCompany(reno);
            this.addNewItemsToAllContainers(newItemsOnSale);
            this.addItemsToOneContainer(newItemsOnSpecial, "Dallas-02");
            this.createIndexOfItems();
            
            
            
            


        }

        public void addNewItemsToAllContainers(List <Item> newItems)
        {

            for(int i = 0 ; i < this._warehouses.Count; i++)
            {
                for(int j = 0 ; j < this._warehouses[i]._whContainers.Count; j ++)

                    {
                        this._warehouses[i]._whContainers[j].addMultipleItemsToContainer(newItems);
                      

                    }
                   


            }


        }
        public void addItemsToOneContainer(List <Item> myItem, string containerID)
        {

            for(int i = 0 ; i < this._warehouses.Count ; i ++)
            {
                for(int j = 0; j < this._warehouses[i]._whContainers.Count ;j++)
                {
                    if(containerID == this._warehouses[i]._whContainers[j].id)
                    {
                        this._warehouses[i]._whContainers[j].addMultipleItemsToContainer(myItem);

                    }
                }

            }


        }




        public void printCompanyManifest()
        {
            Console.WriteLine(this.name);
            

                 for(int i = 0 ; i < this._warehouses.Count; i ++)
                {
                    Console.Write("\t");
                    Console.WriteLine(this._warehouses[i].name);
                    
                    for(int j = 0 ; j < this._warehouses[i]._whContainers.Count; j ++)
                    {
                    Console.Write("\t");
                    Console.Write("\t");
                    Console.WriteLine(this._warehouses[i]._whContainers[j].id);
                    Console.WriteLine("");
                    Console.WriteLine(this._warehouses[i]._whContainers[j].containerItems);
                    }

                }

        }


        public List<Tuple<string,string>> createIndexOfItems( )
        {
            List<Tuple<string, string>> myCompanyIndex =
                new List<Tuple<string,string>>();
           
            for( int i =0 ; i < this._warehouses.Count ; i ++)
            {   
                for(int j = 0; j < this._warehouses[i]._whContainers.Count; j ++)
                {

                    for(int k = 0 ; k < this._warehouses[i]._whContainers[j].getItemsInContainer().Count; k++)
                    {
                        List <Item> myItemsInContainer = this._warehouses[i]._whContainers[j].getItemsInContainer();
                        myCompanyIndex.Add(new Tuple<string,string>(myItemsInContainer[k].name , this._warehouses[i]._whContainers[j].id));
                        
                    }

                }


            }

            //To verify contents of Index
            /*  foreach(Tuple<string,string> tuple in myCompanyIndex)
            {
                string x = tuple.Item1;
                string y = tuple.Item2;
                Console.WriteLine("{0} : {1}", x, y);
                
            }*/

            return myCompanyIndex;

        }

        public string findLocation(string myItem)
        {
            string location = "Not Found.";

            List<Tuple<string,string>> myCompaniesIndex = createIndexOfItems();



            foreach(Tuple<string, string> tuple in myCompaniesIndex)
            {
                
                if(myItem == tuple.Item1)
                {
                    //Console.WriteLine($"{tuple.Item1} - {tuple.Item2}");
                    location = String.Concat(tuple.Item1," is located at ", tuple.Item2);
                    return location;
                    
                }      

            }

            return location;


        }
      



    }


}