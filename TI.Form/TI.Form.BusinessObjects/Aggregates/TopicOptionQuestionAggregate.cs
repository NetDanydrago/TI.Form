using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.POCOEntities;
using TI.Form.BusinessObjects.ValueObjects;

namespace TI.Form.BusinessObjects.Aggregates
{
    public class TopicOptionQuestionAggregate : TopicQuestion
    {
        readonly List<OptionQuestion> OptionQuestionField = new();
        public IReadOnlyCollection<OptionQuestion> OptionQuestions => OptionQuestionField;

        public int TopicId { get; set; }

        public void AddQuestion(OptionQuestion optionQuestion)
        {
                OptionQuestionField.Add(optionQuestion);
        }
    }
}
