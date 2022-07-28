
using TI.Form.BusinessObjects.DTOs.Create;

namespace TI.Form.UseCases.Create
{
    public class CreateInteractor : ICreateInputPort
    {
        readonly ICommandsRepository Repository;
        readonly ICreateOutputPort OutputPort;

        public CreateInteractor(ICommandsRepository repository, ICreateOutputPort outputPort)
        {
            Repository = repository;
            OutputPort = outputPort;
        }

        public async ValueTask Handle(CreateDTO createDTO)
        {

            await Repository.Create(new TopicOptionQuestionAggregate());
            await Repository.SaveChanges();
            await OutputPort.Handle(1);
        }
    }
}
