

using TI.Form.BusinessObjects.DTOs.Create;

namespace TI.Form.WebApi
{
    public static class Endpoints
    {
        public static WebApplication UseCreateEndpoints(this WebApplication app)
        {
            app.MapPost("/create", async (CreateDTO order, ICreateController controller) =>
            Results.Ok(await controller.CreateOrder(order)));
            return app;
        }
    }
}
