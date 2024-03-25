using Company.Core.Contracts;
using Company.Infrastructure.Repositories;

namespace Company.ServiceExtension
{
    public static class ServiceExtensions
    {

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
         services.AddScoped<IRepositoryManager, RepositoryManager>();

    }
}
