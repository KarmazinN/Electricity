namespace Electricity.Api.Models
{
    public class UpdateStatusRequest
    {
        public int SpreadsheetId { get; set; }
        public string Hour { get; set; }
        public bool Status { get; set; }
    }
}
