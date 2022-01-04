using FullStack.Domain.Interfaces;
using FullStack.Domain.Model;
using FullStack.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.Infrastructure.Data.Repository
{
    public class TodoRepository : IToDoRepository
    {
        public FullStackDbContext _context;

        public TodoRepository(FullStackDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ToDo> GetToDos()
        {
            // Add this line
            return _context.Todos;
        }

    }
}
