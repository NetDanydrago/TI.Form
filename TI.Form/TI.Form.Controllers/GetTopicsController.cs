


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
    public class GetTopicsController : IGetTopicsController
    {
        readonly IGetTopicsInputPort GetTopicsInputPort;

        public GetTopicsController(IGetTopicsInputPort getTopicsInputPort)
        {
            GetTopicsInputPort=getTopicsInputPort;
        }

        public ValueTask<List<Topic>> GetTopics()
        {
            return GetTopicsInputPort.Handle();
        }
    }
}
