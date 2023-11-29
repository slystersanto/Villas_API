using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla.API.Models.Dto
{
    public class VillaDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Name { get; set; } = string.Empty;

        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }

        public int Sqft { get; set; }

        public int Ocupncy { get; set; }

        public string ImageUrl { get; set; }

        public string Amenity { get; set; }


    }
}
