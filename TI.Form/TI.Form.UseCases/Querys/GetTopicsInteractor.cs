using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.Interfaces.Ports.Querys;
using TI.Form.BusinessObjects.POCOEntities;

namespace TI.Form.UseCases.Querys
{
    public class GetTopicsInteractor : IGetTopicsInputPort
    {
        IQuerysRepository Repository;

        public GetTopicsInteractor(IQuerysRepository repository)
        {
            Repository=repository;
        }

        public async ValueTask<List<Topic>> Handle()
        {
          return  await Repository.GetTopics();
        }
    }
}
