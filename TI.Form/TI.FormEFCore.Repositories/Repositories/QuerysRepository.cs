using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.FormEFCore.Repositories.Repositories
{
    public class QuerysRepository : IQuerysRepository
    {
        readonly Context Context;

        public QuerysRepository(Context context)
        {
            Context=context;
        }

        public async ValueTask<Topic> GetTopic(int topicId)
        {
            return await Context.Topics.Where(t => t.Id == topicId).FirstOrDefaultAsync();
        }

        public async ValueTask<List<Topic>> GetTopics()
        {
            return await Context.Topics.ToListAsync();
        }
    }
}
