using System;
using System.Collections.Generic;


namespace OOPS1
{

    public class Container
    {
        List <Item> _items = new List<Item>{ 
            new Item(0.50m,"apple"), new Item(0.69m, "banana"),  new Item(1.10m , "pineapple") } ;

        string _id = "";
        int _size = 0;

        // empty contained with no items
        public Container(string myId )
        {
            this._size = _items.Count;
            if(myId == "")
            {
                this._id = "Austin-00";  
            }     

            else
            {

                this._id = myId;
            }
        
        }


        // container with items
        public Container( List <Item> myItems, string myId, int mySize)
        {
            this._items = myItems;
            this.size = mySize;
            this._id = myId;

        }

        public string id
        {
            get
            {
                return this._id;
            }
            
            set
            {
                this._id = value ;
            }
        
        }

        public int size
        {
            get
            {
                return this._size;
            }

            set
            {
                this._size = value;
            }
        }

        public string containerItems
        {
            get
            {
                foreach(Item i in _items)
                {
                    
                    Console.Write("\t");Console.Write("\t");Console.Write("\t");
                    Console.WriteLine("This container contains an {0} at a price of ${1}", i.name, i.price);

                }

                return "\n";

            }


        }

        public void addItemToContainer(Item a )
        {

            this._items.Add(a);


        }

        public void addMultipleItemsToContainer(List <Item> myItems)
        {

            foreach(Item i in myItems)
            {

                this._items.Add(i);

            }


        }

        public List <Item> getItemsInContainer()
        {
            return _items;

        }

        public int getIndexOfItem(string myItem)
        {
            int index = 0;
            for(int i = 0; i < this._items.Count ; i ++)
            {
                if( myItem == this._items[i].name)
                {
                    index = i;
                    return index;

                }

            }

            return index;


        }
        

        
    }


}