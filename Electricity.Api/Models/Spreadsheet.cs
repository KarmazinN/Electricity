using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Electricity.Api.Models
{
    public class Spreadsheet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CityId { get; set; }
        public int GroupId { get; set; }
        public DateTime Date { get; set; }
        public string DateName { get; set; }

        public bool Hour00 { get; set; }
        public bool Hour01 { get; set; }
        public bool Hour02 { get; set; }
        public bool Hour03 { get; set; }

        public bool Hour04 { get; set; }
        public bool Hour05 { get; set; }
        public bool Hour06 { get; set; }
        public bool Hour07 { get; set; }

        public bool Hour08 { get; set; }
        public bool Hour09 { get; set; }
        public bool Hour10 { get; set; }
        public bool Hour11 { get; set; }

        public bool Hour12 { get; set; }
        public bool Hour13 { get; set; }
        public bool Hour14 { get; set; }
        public bool Hour15 { get; set; }

        public bool Hour16 { get; set; }
        public bool Hour17 { get; set; }
        public bool Hour18 { get; set; }
        public bool Hour19 { get; set; }

        public bool Hour20 { get; set; }
        public bool Hour21 { get; set; }
        public bool Hour22 { get; set; }
        public bool Hour23 { get; set; }

    }
}
