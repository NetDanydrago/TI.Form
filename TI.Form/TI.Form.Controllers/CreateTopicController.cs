using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.DTOs.Create;

namespace TI.Form.Controllers
{
    public class CreateTopicController : ICreateTopicController
    {
        readonly ICreateTopicInputPort CreateTopicInputPort;
        readonly ICreateTopicPresenter CreateTopicPresenter;

        public CreateTopicController(ICreateTopicInputPort createTopicInputPort, ICreateTopicPresenter createTopicPresenter)
        {
            CreateTopicInputPort=createTopicInputPort;
            CreateTopicPresenter=createTopicPresenter;
        }

        public async ValueTask<int> CreateTopic(CreateTopicDTO createOrderDTO)
        {
            await CreateTopicInputPort.Handle(createOrderDTO);
            return CreateTopicPresenter.Id;
        }
    }
}
