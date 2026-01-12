using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FredsBoats.Web.Models
{
    [Table("category")] // Maps to the specific table name in your diagram
    public class Category
    {
        [Key]
        [Column("categoryid")]
        public int CategoryId { get; set; }

        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        // Navigation Property: One Category has many Boats
        public ICollection<Boat> Boats { get; set; } = new List<Boat>();
    }
}