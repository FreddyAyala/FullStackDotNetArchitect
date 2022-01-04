using FullStack.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.Domain.Interfaces
{
    public interface ITodoService
    {
        TodoViewModel GetTodos();
    }
}
