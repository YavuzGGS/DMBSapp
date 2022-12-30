using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class MEFReadsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"data source=DESKTOP-QK122C6;initial catalog=MEFReads;trusted_connection=true;TrustServerCertificate=Yes"); 
                                                                                                                               //Need your own connection string
                                                                                                                                 //since we are using localDB
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Library> Library { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book_Genre> Book_Genres { get; set; }




    }
}
