using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Web4Core.Implements.Documents;

namespace Web4Core.Infrastructure
{
    public static class IocConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IDocumentManager, DocumentManager>();
        }
    }
}
