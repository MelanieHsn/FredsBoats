using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FredsBoats.Web.Models
{
    [Table("boat_colour")]
    public class BoatColour
    {
        [Key]
        [Column("colourid")]
        public int ColourId { get; set; }

        [Column("name")]
        [StringLength(20)]
        public string Name { get; set; } = string.Empty;

        // Navigation Property
        public ICollection<Boat> Boats { get; set; } = new List<Boat>();
    }
}