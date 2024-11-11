using Electricity.Api.Data.Repositories.Interfaces;
using Electricity.Api.Models;

namespace Electricity.Api.Data.Repositories
{
    public class ZoneRepository(AppDbContext dbContext) : RepositoryBase<Zone>(dbContext), IZoneRepository
    {
    }
}
