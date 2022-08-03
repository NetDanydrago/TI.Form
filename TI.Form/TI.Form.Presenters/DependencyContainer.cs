
namespace TI.Form.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<CreateTopicPresenter>();
            services.AddScoped<ICreateTopicPresenter, CreateTopicPresenter>(
                provider => provider.GetService<CreateTopicPresenter>());
            services.AddScoped<ICreateTopicOutputPort, CreateTopicPresenter>(
                provider => provider.GetService<CreateTopicPresenter>());
            return services;
        }
    }
}
