using System;
using System.Collections.Generic;
using System.Text;

namespace TI.Form.BusinessObjects.ValueObjects
{
    public record struct Option(string TextOption, bool IsCorrect);
}
