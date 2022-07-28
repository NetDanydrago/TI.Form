﻿

namespace TI.Form.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddTI.FormServices(this IServiceCollection services,
            IConfiguration configuration, string connectionStringName)
        {
            services.AddRepositories(configuration, connectionStringName);
            services.AddUseCasesServices();
            services.AddPresenters();
            services.AddControllers();
            return services;
        }
    }
}
