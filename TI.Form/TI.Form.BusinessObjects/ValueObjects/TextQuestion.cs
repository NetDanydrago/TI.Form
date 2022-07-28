using System;
using System.Collections.Generic;
using System.Text;

namespace TI.Form.BusinessObjects.ValueObjects
{
    public record struct TextQuestion(string Question, int OrderNumber, string QuestionAnwser);
}
