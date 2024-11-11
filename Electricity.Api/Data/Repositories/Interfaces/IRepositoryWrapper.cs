namespace Electricity.Api.Data.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        ICityRepository CityRepository { get; }
        IZoneRepository ZoneRepository { get; }
        ISpreadsheetRepository SpreadsheetRepository { get; }

        public int SaveChanges();
        public Task<int> SaveChangesAsync();
    }
}
