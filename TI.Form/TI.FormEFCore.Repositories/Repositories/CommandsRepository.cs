
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.FormEFCore.Repositories.Repositories
{
    public class CommandsRepository : ICommandsRepository
    {
        readonly Context Context;

        public CommandsRepository(Context context)
        {
            Context = context;
        }

        public async ValueTask Create(TopicOptionQuestionAggregate aggregate)
        {
            await Context.AddAsync(aggregate);
        }

        public async ValueTask SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}
