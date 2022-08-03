using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.DTOs.Create;
using TI.Form.BusinessObjects.POCOEntities;

namespace TI.Form.UseCases.Create
{
    public class CreateTopicInteractor : ICreateTopicInputPort
    {
        readonly ICommandsRepository Repository;
        readonly ICreateTopicOutputPort OutputPort;

        public CreateTopicInteractor(ICommandsRepository repository, ICreateTopicOutputPort outputPort)
        {
            Repository=repository;
            OutputPort=outputPort;
        }

        public async ValueTask Handle(CreateTopicDTO topicDTO)
        {
            Topic Topic = new Topic()
            {
                Title = topicDTO.Title,
                Description = topicDTO.Description,
            };
            await Repository.CreateTopic(Topic);
            await Repository.SaveChanges();
            await OutputPort.Handle(Topic.Id);
        }
    }
}
