using TI.Form.BusinessObjects.Interfaces.Ports.Querys;
using TI.Form.UseCases.Querys;

namespace TI.Form.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateTopicInputPort, CreateTopicInteractor>();
            services.AddScoped<ICreateQuestionInputPort, CreateQuestionInteractor>();

            services.AddScoped<IGetTopicInputPort, GetTopicInteractor>();
            services.AddScoped<IGetTopicInputPort, GetTopicInteractor>();
            services.AddScoped<IGetTopicsInputPort, GetTopicsInteractor>();
            services.AddScoped<IGetTopicsInputPort, GetTopicsInteractor>();
            return services;
        }
    }
}
