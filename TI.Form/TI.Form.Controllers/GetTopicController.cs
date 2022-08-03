using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.Interfaces.Controllers.Querys;
using TI.Form.BusinessObjects.Interfaces.Ports.Querys;
using TI.Form.BusinessObjects.POCOEntities;

namespace TI.Form.Controllers
{
    public class GetTopicController : IGetTopicController
    {
        readonly IGetTopicInputPort GetTopicInputPort;

        public GetTopicController(IGetTopicInputPort getTopicInputPort)
        {
            GetTopicInputPort=getTopicInputPort;
        }

        public async ValueTask<Topic> GetTopic(int topicId)
        {
            return await GetTopicInputPort.Handle(topicId);
        }
    }
}
