using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class Application
    {
        DbContextOptions<ToDoDBContext> options;
        DbContextOptionsBuilder<ToDoDBContext> builder;
        ToDoDatabase todoDB;
        ToDoDBContext context;


        public Application()
        {


            this.todoDB = new ToDoDatabase();

            this.builder = new DbContextOptionsBuilder<ToDoDBContext>();

            this.builder.UseSqlServer(todoDB.connectionString);

            this.options = builder.Options;

            this.context = new ToDoDBContext(options);

        }



        public void buildApp()
        {
            //isCreated = context.Database.EnsureCreated();

            string input = "";
            Console.WriteLine("Welcome to your ToDo List.");
            Console.WriteLine("Type 'a' to add a new item:");
            Console.WriteLine("Type 'e' to edit an existing item:");
            Console.WriteLine("Type 'r' to remove an item:");
            Console.WriteLine("Type 'm' to mark an item completed:");
            Console.WriteLine("Type 'd' to display ToDo item.");
            Console.WriteLine("Type 'p' to display ToDo List.");

            input = Console.ReadLine();


            switch (input.ToLower())
            {

                case "a":
                    AddToDoItem();
                    PrintToDoItems();
                    break;
                case "e":
                    EditToDoItem();
                    PrintToDoItems();
                    break;
                case "r":
                    RemoveToDoItem();
                    PrintToDoItems();
                    break;
                case "m":
                    MarkItemComplete();
                    PrintToDoItems();
                    break;
                case "d":
                    DisplayItemByID();
                    break;
                case "p":
                    PrintToDoItems();
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;



            }
            Console.WriteLine();

            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();


        }
        public void PrintToDoItems()
        {
            Console.WriteLine("Here is your current ToDo List:");

            foreach (var t in context.ToDOS)
            {
                Console.WriteLine();
                Console.Write("ID: {0} ", t.ID);
                Console.WriteLine("Title: {0}  ", t.Title);
                Console.WriteLine("ToDo: {0}", t.Content);
                Console.WriteLine("Is Completed : {0}", t.IsComplete);
                Console.WriteLine();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


            }


        }

        private ToDo createToDo()
        {
            string myTitle = "";
            string myContent = "";
            DateTime dtNow = DateTime.Now;
            bool completed = false;
            ToDo myTD;

            Console.WriteLine("Title: ");
            myTitle = Console.ReadLine();
            if (myTitle == "")
            {
                myTitle = "Default";

            }


            Console.WriteLine("Item To Do:  ");
            myContent = Console.ReadLine();
            if (myContent == "")
            {

                myContent = "Default";

            }


            myTD = new ToDo
            {
                Title = myTitle,
                Content = myContent,
                CreateDate = dtNow,
                IsComplete = completed

            };


            return myTD;



        }

        public void EditToDoItem()
        {

            int myId;
            ToDo myTD;
            string newContent = "";
            string newTitle = "";

            PrintToDoItems();

            Console.WriteLine("What is the id of the item you would like to edit?");
            int.TryParse(Console.ReadLine(), out myId);
            myTD = findById(myId);

            if (myTD.ID > 0)
            {
                Console.WriteLine("What is the new title for your item?");
                newTitle = Console.ReadLine();
                Console.WriteLine("What is the new thing you need to do?");
                newContent = Console.ReadLine();

                myTD.Title = newTitle;
                myTD.Content = newContent;
                this.context.ToDOS.Update(myTD);
                this.context.SaveChanges();


            }
            else
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!");
                Console.WriteLine("Invalid ID");
                Console.WriteLine("!!!!!!!!!!!!!!!!!");
            }





        }

        public void DisplayItemByID()
        {
            ToDo myTD;
            int myId;

            Console.WriteLine("What item would you like to display?");
            int.TryParse(Console.ReadLine(), out myId);

            myTD = findById(myId);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("ID:{0} ", myTD.ID);
            Console.WriteLine("Title: {0}", myTD.Title);
            Console.WriteLine("ToDo Item: {0}", myTD.Content);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");




        }

        public void MarkItemComplete()
        {
            int id;
            PrintToDoItems();
            Console.WriteLine("What is the id of the item, you want to mark completed?");
            int.TryParse(Console.ReadLine(), out id);

            ToDo myTD = findById(id);
            if (myTD.ID > 0)
            {
                myTD.IsComplete = true;
                context.ToDOS.Update(myTD);
                context.SaveChanges();
            }



        }


        public void AddToDoItem()
        {
            bool finished = false;
            string input = "";
            while (!finished)
            {
                AddToDo(createToDo());

                Console.WriteLine("Did you want to add another? y/n");
                input = Console.ReadLine();
                if (input.ToLower() == "n" || input.ToLower() == "no")
                {
                    finished = true;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("OK, let's add another item.");
                }

            }

        }




        public void RemoveToDoItem()
        {
            int myId;
            bool itemRemoved = false;
            PrintToDoItems();
            Console.WriteLine("What is the id of the item you wish to remove?");
            int.TryParse(Console.ReadLine(), out myId);
            itemRemoved = removeToDo(myId);
            if (itemRemoved)
            {
                Console.WriteLine("Your item has been removed.");
            }



        }


        private void AddToDo(ToDo t)
        {

            this.context.ToDOS.Add(t);

        }

        private bool removeToDo(int id)
        {
            bool removed = false;
            if (findById(id).ID != -1)
            {
                try
                {
                    this.context.ToDOS.Remove(findById(id));
                    context.SaveChanges();
                    removed = true;

                }
                catch (System.InvalidOperationException ex)
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!!!");
                    throw new System.Exception("!!!!!ID not found.!!!!!", ex);

                }

            }
            else
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!!");
                Console.WriteLine("Not a valid value");
                Console.WriteLine("!!!!!!!!!!!!!!!!!");
            }

            return removed;

        }



        private ToDo findById(int id)
        {
            ToDo td;
            td = this.context.ToDOS.Find(id);
            if (td != null)
            { return td; }

            else
            {
                td = new ToDo { ID = -1, Title = "", Content = "", CreateDate = DateTime.Now, IsComplete = false };
                Console.WriteLine("!!!!!!!!!!!!!!!!!");
                Console.WriteLine("Item not found.");
                Console.WriteLine("!!!!!!!!!!!!!!!!!");
                return td;
            }

        }
    }
}
