using FullStack.Domain.Interfaces;
using FullStack.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStack.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private ITodoService _todoService; 
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;

        }

        [HttpGet]
        public TodoViewModel Index()
        {
            var model = _todoService.GetTodos();
            return model;

        }
    }
}
