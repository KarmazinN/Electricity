using Electricity.Api.Data.Repositories.Interfaces;
using Electricity.Api.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Electricity.Api.Data
{
    public static class DataExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                options.UseMySql(
                    connectionString, ServerVersion.AutoDetect(connectionString)
                );
            });

            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IZoneRepository, ZoneRepository>();
            services.AddScoped<ISpreadsheetRepository, SpreadsheetRepository>();

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

            using var scope = services.BuildServiceProvider().CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            var pendingMigrations = dbContext.Database.GetPendingMigrations();
            if (pendingMigrations.Any())
            {
                dbContext.Database.Migrate();
            }
        }
    }
}
