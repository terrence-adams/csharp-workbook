using System;
using System.Collections.Generic;

namespace OOPS1
{
    class Program
    {
        static void Main(string[] args)
        {

            Company Rainforest = new Company("Rainforest");
            Rainforest.buildCompany();
            Console.WriteLine(Rainforest.findLocation("tangerine"));
            Rainforest.printCompanyManifest();
            
           

        }


        
    }


}
