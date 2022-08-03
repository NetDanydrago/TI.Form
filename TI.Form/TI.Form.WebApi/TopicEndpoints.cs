

using TI.Form.BusinessObjects.DTOs.Create;

namespace TI.Form.WebApi
{
    public static class TopicEndpoints
    {
        public static WebApplication UseTopicEndpoints(this WebApplication app)
        {
            app.MapPost("/AddTopic", async (CreateTopicDTO Topic, ICreateTopicController controller) =>
            Results.Ok(await controller.CreateTopic(Topic)));
            return app;
        }
    }
}
