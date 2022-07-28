using System;
using System.Collections.Generic;
using System.Text;
using TI.Form.BusinessObjects.ValueObjects;

namespace TI.FormEFCore.Repositories.Entities
{
    public class TopicQuestion
    {
        public int Id { get; set; }
        public string TypeQuestion { get; set; }

        public int TopicId { get; set; }

        public OptionQuestion OptionQuestions { get; set; }
        public TextQuestion TextQuestions { get; set; }

    }
}
