using TI.Form.BusinessObjects.DTOs.Create;

namespace TI.Form.WebApi
{
    public static class QuestionEndpoints
    {
        public static WebApplication UseQuestionEndpoints(this WebApplication app)
        {
            app.MapPost("/AddQuestion", async (CreateQuestionDTO Question, ICreateQuestionController controller) =>
            {
                await controller.CreateQuestion(Question);
                Results.Ok();
            });
            return app;
        }
    }
}
