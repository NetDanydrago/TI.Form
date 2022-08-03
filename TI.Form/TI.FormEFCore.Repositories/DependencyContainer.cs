using Microsoft.Extensions.Configuration;


namespace TI.FormEFCore.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<Context>(options =>
            options.UseSqlServer(configuration.GetConnectionString(connectionStringName)));
            services.AddScoped<ICommandsRepository, CommandsRepository>();
            services.AddScoped<IQuerysRepository, QuerysRepository>();
            return services;
        }
    }
}
