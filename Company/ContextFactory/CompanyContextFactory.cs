using Company.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Company.ContextFactory
{
    public class CompanyContextFactory : IDesignTimeDbContextFactory<CompanyContext>
    {
        public CompanyContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var builder = new DbContextOptionsBuilder<CompanyContext>()
            .UseSqlServer(configuration.GetConnectionString("CompanyContext"),
             b => b.MigrationsAssembly("Company"));

            return new CompanyContext(builder.Options);
        }
    }
}
