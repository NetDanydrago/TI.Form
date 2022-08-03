using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.POCOEntities;

namespace TI.Form.BusinessObjects.Interfaces.Ports.Querys
{
    public interface IGetTopicInputPort
    {
        ValueTask<Topic> Handle(int topicId);
    }
}
