using System;
using System.Collections.Generic;
using System.Text;

namespace TI.Form.BusinessObjects.ValueObjects
{
    public class Option
    {
        public int Id { get; set; }
        public string AnswerOption { get; set; }

        public int OptionQuestionId { get; set; }

    }
}
