using System;
using System.Collections.Generic;
using System.Text;

namespace TI.Form.BusinessObjects.ValueObjects
{
    public record struct OptionQuestion(string Question, int OrderNumber, List<Option> Options);
}
