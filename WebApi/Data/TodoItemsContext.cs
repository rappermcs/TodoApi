using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class TodoItemsContext : DbContext
    {
        public TodoItemsContext (DbContextOptions<TodoItemsContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; }
    }
}
