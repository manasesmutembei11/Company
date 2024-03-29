using Company.Core.Contracts;
using Company.Core.Contracts.IService;
using Company.Infrastructure.Repositories;
using Company.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Company.Infrastructure.Data;
using Company.Core.Interfaces.ILogger;
using Company.Infrastructure.LoggerManager;

namespace Company.ServiceExtension
{
    public static class ServiceExtensions
    {

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) => 
            services.AddSqlServer<CompanyContext>((configuration.GetConnectionString("CompanyContext")));

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();


    }
}
