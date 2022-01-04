using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.Domain.Model
{
    public class ToDo
    {
        public int Id {get;set;}
        public string Title { get; set; }
        public bool IsDone { get; set; }

    }
}
