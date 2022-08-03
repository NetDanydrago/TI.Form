

using TI.Form.BusinessObjects.DTOs.Create;
using TI.Form.BusinessObjects.Interfaces.Controllers.Querys;

namespace TI.Form.WebApi
{
    public static class TopicEndpoints
    {
        public static WebApplication UseTopicEndpoints(this WebApplication app)
        {
            app.MapPost("/AddTopic", async (CreateTopicDTO Topic, ICreateTopicController controller) =>
            Results.Ok(await controller.CreateTopic(Topic)));

            app.MapGet("/GetTopicById", async (int id, IGetTopicController controller) =>
            Results.Ok(await controller.GetTopic(id)));

            app.MapGet("/GetTopics", async (IGetTopicsController controller) =>
            Results.Ok(await controller.GetTopics()));
            return app;
        }
    }
}
