using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    /// <summary>
    /// The database context is the main class that coordinates Entity Framework functionalitiy for a data
    /// model.
    /// </summary>
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            :base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
