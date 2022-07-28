

namespace TI.Form.WebApi
{
    public static class WebApplicationHelper
    {
        public static WebApplication CreateWebApplication(
            this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTI.FormServices(builder.Configuration, "NorthWindDBNET20");
            return builder.Build();
        }

        public static WebApplication ConfigureWebApplication(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseCreateEndpoints();

            }
            return app;
        }
    }
}
