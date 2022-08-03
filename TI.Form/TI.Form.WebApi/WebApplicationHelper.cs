

namespace TI.Form.WebApi
{
    public static class WebApplicationHelper
    {
        public static WebApplication CreateWebApplication(
            this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTIFormServices(builder.Configuration, "FORMSDBNET20");
            return builder.Build();
        }

        public static WebApplication ConfigureWebApplication(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseTopicEndpoints();
                app.UseQuestionEndpoints();

            }
            return app;
        }
    }
}
