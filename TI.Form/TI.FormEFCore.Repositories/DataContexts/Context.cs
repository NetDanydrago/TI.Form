using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace TI.FormEFCore.Repositories.DataContexts
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
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
