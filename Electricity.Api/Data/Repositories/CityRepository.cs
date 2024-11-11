using Electricity.Api.Data.Repositories.Interfaces;
using Electricity.Api.Models;

namespace Electricity.Api.Data.Repositories
{
    public class CityRepository(AppDbContext dbContext) : RepositoryBase<City>(dbContext), ICityRepository
    {
    }
}
