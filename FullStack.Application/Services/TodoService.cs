using FullStack.Domain.Interfaces;
using FullStack.Domain.Model;
using FullStack.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.Application.Services
{
    public class TodoService : ITodoService
    {
        private IToDoRepository _toDoRepository;

        public TodoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public TodoViewModel GetTodos()
        {
            return new TodoViewModel()
            {
                Todos = (IEnumerable<ToDo>)_toDoRepository.GetToDos()
            };
        
        }
    }
}
