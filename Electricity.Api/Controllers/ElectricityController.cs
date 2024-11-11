using Electricity.Api.Data.Repositories.Interfaces;
using Electricity.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Reflection;

namespace Electricity.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElectricityController : ControllerBase
    {
        private readonly IRepositoryWrapper _rp;
        public ElectricityController(IRepositoryWrapper repositoryWrapper)
        {
            _rp = repositoryWrapper;
        }

        [HttpGet("spreadsheet")]
        public async Task<IActionResult> GetElectricitySpreadsheet([FromQuery] int cityId, [FromQuery] int zoneKey)
        {
            DateTime startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(7).AddTicks(-1);

            var city = await _rp.CityRepository.GetFirstOrDefaultAsync(x => x.Id == cityId);
            if (city == null)
            {
                return NotFound(new { message = "Місто не знайдено" });
            }

            var group = await _rp.ZoneRepository.GetFirstOrDefaultAsync(x => x.ZoneKey == zoneKey);
            if (group == null)
            {
                return NotFound(new { message = "Група не знайдена" });
            }

            var result = await _rp.SpreadsheetRepository.GetAllAsync(x => x.GroupId == group.Id 
                && x.CityId == city.Id && x.Date >= startOfWeek && x.Date <= endOfWeek);
            return Ok(result);
        }

        [HttpGet("cities")]
        public async Task<IActionResult> GetCities()
        { 
            var result = await _rp.CityRepository.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("zones/{cityId}")]
        public async Task<IActionResult> GetZonesByCityId(int cityId)
        {
            var cityZones = await _rp.ZoneRepository.GetAllAsync(g => g.CityId == cityId);
            if (!cityZones.Any())
            {
                return NotFound(new { message = "Групи для цього міста не знайдено" });
            }
            return Ok(cityZones);
        }

        [HttpPatch("updateStatus")]
        public async Task<IActionResult> PatchSpreadsheet([FromBody] UpdateStatusRequest request)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            var spreadsheet = await _rp.SpreadsheetRepository.GetFirstOrDefaultAsync(s => s.Id == request.SpreadsheetId);
            if (spreadsheet == null)
            {
                return NotFound();
            }

            var propertyInfo = typeof(Spreadsheet).GetProperty(textInfo.ToTitleCase(request.Hour), BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfo == null || propertyInfo.PropertyType != typeof(bool))
            {
                return BadRequest("Поле не знайдено або його тип не є булевим.");
            }

            propertyInfo.SetValue(spreadsheet, request.Status);

            await _rp.SpreadsheetRepository.UpdateAsync(spreadsheet);

            return NoContent();
        }
    }
}
