using Electricity.Api.Data.Repositories.Interfaces;

namespace Electricity.Api.Data.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly AppDbContext _dbContext;

        private ICityRepository? _cityRepository;
        private IZoneRepository? _zoneRepository;
        private ISpreadsheetRepository? _spreadsheetRepository;


        public ICityRepository CityRepository
        {
            get => _cityRepository == null ? _cityRepository = new CityRepository(_dbContext) : _cityRepository;
        }

        public IZoneRepository ZoneRepository
        {
            get => _zoneRepository == null ? _zoneRepository = new ZoneRepository(_dbContext) : _zoneRepository;
        }

        public ISpreadsheetRepository SpreadsheetRepository
        {
            get => _spreadsheetRepository == null ? _spreadsheetRepository = new SpreadsheetRepository(_dbContext) : _spreadsheetRepository;
        }

        public RepositoryWrapper(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
