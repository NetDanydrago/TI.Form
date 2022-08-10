using TI.Form.BusinessObjects.DTOs.Create;

namespace TI.Form.Blazor.Pages
{
    public partial class CardQuestions
    {
        //Comentario
        bool ShowAnwser { get; set; }
        int IndexQuestion { get; set; }
        bool IsVisibleImage { get; set; }



        List<CreateQuestionDTO> Questions = new List<CreateQuestionDTO>()
        {
        new CreateQuestionDTO()
       {
           TopicId = 1,
           OrderNumber = 1,
           ImageUrl = "/...",
           Question = "Esta es la pregunta 1 Un párrafo es una unidad de un texto compuesta por una o varias oraciones, que comienza con una mayúscula y que termina con un punto y aparte. Los textos se organizan de manera tal que cada párrafo trata sobre una idea central. Generalmente, la primera oración de cada párrafo suele explicitar cuál es el punto principal que se desarrollará.",
           Options = new List<CreateOptionDTO>()
           {
               new CreateOptionDTO()
               {
                   TextOption = "Esta es la Respuesta correcta",
                   IsCorrect = true,
               },
               new CreateOptionDTO()
               {
                   TextOption = "Esta es la Respuesta incorrecta",
                   IsCorrect = false,
               },
                new CreateOptionDTO()
               {
                   TextOption = "Esta es la Respuesta incorrecta",
                   IsCorrect = false,
               }
           }.Shuffle()
         },
        new CreateQuestionDTO()
        {
           TopicId = 1,
           OrderNumber = 2,
           Question = "Esta es la pregunta 2 Un párrafo es una unidad de un texto compuesta por una o varias oraciones, que comienza con una mayúscula y que termina con un punto y aparte. Los textos se organizan de manera tal que cada párrafo trata sobre una idea central. Generalmente, la primera oración de cada párrafo suele explicitar cuál es el punto principal que se desarrollará.",
           Options = new List<CreateOptionDTO>()
           {
               new CreateOptionDTO()
               {
                   TextOption = "Esta es la Respuesta correcta",
                   IsCorrect = true,
               },
               new CreateOptionDTO()
               {
                   TextOption = "Esta es la Respuesta incorrecta",
                   IsCorrect = false,
               },
                new CreateOptionDTO()
               {
                   TextOption = "Esta es la Respuesta incorrecta",
                   IsCorrect = false,
               }
            }.Shuffle()
         },
        new CreateQuestionDTO()
        {
           TopicId = 1,
           OrderNumber = 3,
           ImageUrl = "/...",
           Question = "Esta es la pregunta 3 Un párrafo es una unidad de un texto compuesta por una o varias oraciones, que comienza con una mayúscula y que termina con un punto y aparte. Los textos se organizan de manera tal que cada párrafo trata sobre una idea central. Generalmente, la primera oración de cada párrafo suele explicitar cuál es el punto principal que se desarrollará.",
           Options = new List<CreateOptionDTO>()
           {
               new CreateOptionDTO()
               {
                   TextOption = "Esta es la Respuesta correcta",
                   IsCorrect = true,
               },
               new CreateOptionDTO()
               {
                   TextOption = "Esta es la Respuesta incorrecta",
                   IsCorrect = false,
               },
                new CreateOptionDTO()
               {
                   TextOption = "Esta es la Respuesta incorrecta",
                   IsCorrect = false,
               }
           }.Shuffle()
        }
    };

    }
}
