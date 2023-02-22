using Microsoft.Extensions.DependencyInjection;
using TaskQueueTemplate.Interfaces;

namespace TaskQueueTemplate
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterTaskQueueTemplateServices(this IServiceCollection services)
        {
            services.AddTransient<DataContext>(sp => DataContext.Create());
            services.AddScoped<ITaskQueueTemplateService, TaskQueueTemplateService>();
            services.AddScoped<ITaskQueueTemplateSettings, TaskQueueTemplateSettings>();

            return services;
        }
    }
}
