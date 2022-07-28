
namespace TI.Form.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<CreatePresenter>();
            services.AddScoped<ICreatePresenter, CreatePresenter>(
                provider => provider.GetService<CreatePresenter>());
            services.AddScoped<ICreateOutputPort, CreatePresenter>(
                provider => provider.GetService<CreatePresenter>());
            return services;
        }
    }
}
