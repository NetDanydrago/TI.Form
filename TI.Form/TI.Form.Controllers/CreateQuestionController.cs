using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.DTOs.Create;

namespace TI.Form.Controllers
{
    public class CreateQuestionController : ICreateQuestionController
    {
        ICreateQuestionInputPort CreateQuestionInputPort;

        public CreateQuestionController(ICreateQuestionInputPort createQuestionInputPort)
        {
            CreateQuestionInputPort=createQuestionInputPort;
        }

        public async ValueTask CreateQuestion(CreateQuestionDTO createQuestionDTO)
        {
            await CreateQuestionInputPort.Handle(createQuestionDTO);
        }
    }
}
