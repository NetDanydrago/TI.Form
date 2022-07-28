using TI.Form.BusinessObjects.Aggregates;
using TI.Form.BusinessObjects.DTOs.Create;
using TI.Form.Entities.Interfaces;

namespace TI.Form.BusinessObjects.Interfaces.Repositories
{
    public interface ICommandsRepository : IUnitOfWork
    {
        ValueTask CreateTopic(CreateTopicDTO topicDTO);

        ValueTask CreateTopicQuestion(TopicOptionQuestionAggregate aggregate);
    }
}
