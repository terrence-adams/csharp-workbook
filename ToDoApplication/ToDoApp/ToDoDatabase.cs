using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class ToDoDatabase
    {
        public string connectionString
        {
            get
            { return "Server=(localdb)\\MSSQLLocalDB;Database= ToDoDB;Trusted_Connection=True"; }

            set
            { }


        }
    }
}
