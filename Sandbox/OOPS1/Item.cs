using System;
using System.Collections.Generic;


namespace OOPS1
{
   public class Item
   {
        string _name = "";

        decimal _price = 0.00m;

        public Item(decimal price,string name)
        {
            _name = name;
            _price = price;

        }

        public decimal price
        {
            get
            {

                return this._price;

             }
            
        
        
            set
            {
                this._price = value;
            }
        
        
        
        }

        public string name
        {
                get
                {
                    return this._name;

                }
                
                set
                {
                    this._name = value;

                }
            
        }


   }




}