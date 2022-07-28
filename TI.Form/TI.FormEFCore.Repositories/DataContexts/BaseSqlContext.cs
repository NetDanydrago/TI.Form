using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace TI.FormEFCore.Repositories.DataContexts
{
    internal class BaseSqlContext : DbContext
    {
        //Add-Migration InitialCreate -p TI.FormEFCore.Repositories -s TI.FormEFCore.Repositories -c BaseSqlContextContext
        //update-database InitialCreate -p TI.FormEFCore.Repositories -s TI.FormEFCore.Repositories -context BaseSqlContextContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database = CleanNET20");
        }

        public DbSet<Create> Creates { get; set; }
        public DbSet<Detail> Details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
