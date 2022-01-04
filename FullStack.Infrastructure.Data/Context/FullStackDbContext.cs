using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FullStack.Domain.Model;


namespace FullStack.Infrastructure.Data.Context
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options) { }
        public DbSet<ToDo> Todos { get; set; }
    }
}
