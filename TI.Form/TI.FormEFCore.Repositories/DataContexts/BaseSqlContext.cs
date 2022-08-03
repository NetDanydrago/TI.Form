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
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database = FormNET20");
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Entities.Question> Questions { get; set; }
        public DbSet<Entities.Option> Options { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
