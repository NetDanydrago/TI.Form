using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.Interfaces.Ports.Querys;
using TI.Form.BusinessObjects.POCOEntities;

namespace TI.Form.UseCases.Querys
{
    internal class GetTopicInteractor : IGetTopicInputPort
    {
        IQuerysRepository Repository;

        public GetTopicInteractor(IQuerysRepository repository)
        {
            Repository=repository;
        }

        public async ValueTask<Topic> Handle(int topicId)
        {
           return  await Repository.GetTopic(topicId);         
        }
    }
}
