
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.Form.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreateTopicController, CreateTopicController>();
            services.AddScoped<ICreateQuestionController, CreateQuestionController>();
            return services;
        }
    }
}
