
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace Infrastructure.DB
{
    public class ApplicationContext : DbContext 
    {
        public DbSet<LibraryUser> Users { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").SetBasePath(Directory.GetCurrentDirectory()).Build();
            optionsBuilder.UseSqlite(config.GetConnectionString("DefaultConnection"));
        }


    }
}
