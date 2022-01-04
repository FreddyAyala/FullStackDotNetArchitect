using FullStack.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.Domain.Interfaces
{
    public interface IToDoRepository
    {
        IEnumerable<ToDo> GetToDos();
    }
}
