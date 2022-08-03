
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

        public async ValueTask CreateTopic(Topic topic)
        {
            await Context.AddAsync(topic);
        }

        public async ValueTask CreateTopicQuestion(QuestionAggregate aggregate)
        {
            var Question = new Entities.Question()
            {
                TopicId = aggregate.TopicId,
                OrderNumber = aggregate.OrderNumber,
                Text = aggregate.Text
            };
            await Context.AddAsync(Question);
            foreach(var Option in aggregate.Options)
            {
                await Context.AddAsync(new Option()
                {
                    Question = Question,
                    Text = Option.TextOption,
                    IsCorrect = Option.IsCorrect,
                });
            }
        }

        public async ValueTask SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}
