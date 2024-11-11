using Electricity.Api.Data.Repositories.Interfaces;
using Electricity.Api.Models;

namespace Electricity.Api.Data.Repositories
{
    public class SpreadsheetRepository(AppDbContext dbContext) : RepositoryBase<Spreadsheet>(dbContext), ISpreadsheetRepository
    {
    }
}
