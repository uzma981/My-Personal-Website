using FirstASPTodo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPTodo.data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        //creating a db set, creates the table
        //writing the code of our model and based on that model, we will create the database
        public DbSet<TodoCategory> Categories { get; set; }

        public DbSet<Expenses> ExpensesList { get; set; }
    }
}
