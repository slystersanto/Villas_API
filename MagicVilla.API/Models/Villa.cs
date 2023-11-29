using System.ComponentModel.DataAnnotations;

namespace MagicVilla.API.Models
{
    public class Villa
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public string Details { get; set; }

        public double Rate { get; set; }
        public int Sqft { get; set; }

        public int Ocupncy { get; set; }

        public string ImageUrl { get; set; }

        public string Amenity { get; set; }
      
        
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
