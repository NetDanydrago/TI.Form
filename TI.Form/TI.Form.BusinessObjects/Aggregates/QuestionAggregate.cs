using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.DTOs.Create;
using TI.Form.BusinessObjects.POCOEntities;
using TI.Form.BusinessObjects.ValueObjects;

namespace TI.Form.BusinessObjects.Aggregates
{
    public class QuestionAggregate : Question
    {
        readonly List<Option> OptionsField = new();
        public IReadOnlyCollection<Option> Options => OptionsField;
        public int TopicId { get; set; }

        public void AddOptions(List<Option> options)
        {
            if(options.Count >=  2)
            {
               var CorrectOptions =  options.Where(O => O.IsCorrect == true).ToList();
                if (CorrectOptions.Count > 0 && CorrectOptions.Count < 2)
                {
                    foreach (var option in options)
                    {
                        OptionsField.Add(option);
                    }
                }
                else
                {
                    throw new Exception("No puede haber mas de dos opciones correctas");
                }
            }
            else
            {
                throw new Exception("Debe haber al menos dos respuestas para la pregunta");
            }
        }


        public static QuestionAggregate From(CreateQuestionDTO createQuestionDTO)
        {
            QuestionAggregate QuestionAggregate = new QuestionAggregate()
            {
                Text = createQuestionDTO.Question,
                OrderNumber = createQuestionDTO.OrderNumber,
                TopicId = createQuestionDTO.TopicId,
            };
            QuestionAggregate.AddOptions(createQuestionDTO.Options.ConvertAll(O => new Option(O.TextOption,O.IsCorrect)));            
            return QuestionAggregate;
        }
    }
}
