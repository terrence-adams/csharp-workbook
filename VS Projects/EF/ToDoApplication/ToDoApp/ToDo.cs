using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    class ToDo
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IsComplete { get; set; }
    }
}
