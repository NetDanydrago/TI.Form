using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.DTOs.Create;

namespace TI.Form.UseCases.Create
{
    public class CreateQuestionInteractor : ICreateQuestionInputPort
    {
        readonly ICommandsRepository Repository;

        public CreateQuestionInteractor(ICommandsRepository repository)
        {
            Repository=repository;
        }

        public async ValueTask Handle(CreateQuestionDTO questionDTO)
        {
            QuestionAggregate Aggregate = QuestionAggregate.From(questionDTO);
            await Repository.CreateTopicQuestion(Aggregate);
            await Repository.SaveChanges();
        }
    }
}
