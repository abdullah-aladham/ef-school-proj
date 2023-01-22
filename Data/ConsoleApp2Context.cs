using ConsoleApp2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Data
{
    internal class ConsoleApp2Context:DbContext
    {
        public DbSet<Teacher>  Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("\"server=localhost;database=BookStore;user=root;password=HelloWorld-1516!\"");
        }
    }
}
