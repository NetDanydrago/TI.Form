using System;
using System.Collections.Generic;
using System.Text;

namespace TI.FormEFCore.Repositories.Entities
{
    public class Option
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public int QuestionId { get; set;  }
        public Question Question { get; set; }

    }
}
