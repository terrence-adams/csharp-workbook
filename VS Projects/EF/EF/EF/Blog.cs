using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class Blog
    {
        public DateTime CreateDate { get; set; }
        public string Title { get; set; }
        public int ID { get; set; }
        public string Content { get; set; }
        public List<Tag> Tags { get; set; }

    }

}
