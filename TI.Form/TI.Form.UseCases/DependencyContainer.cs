namespace TI.Form.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateInputPort, CreateInteractor>();
            return services;
        }
    }
}
