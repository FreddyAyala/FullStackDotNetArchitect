using FullStack.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.Domain.ViewModels
{
   public class TodoViewModel
    {
        public IEnumerable<ToDo> Todos { get; set; }
    }
}
