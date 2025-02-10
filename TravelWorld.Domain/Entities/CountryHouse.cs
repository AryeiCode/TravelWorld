using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelWorld.Domain.Entities
{
    public class CountryHouse
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nombre")]
        [MaxLength(50)]
        public required string Name { get; set; }
        public string? Description { get; set; }
        [Range(10, 10000)]
        public double Price { get; set; }
        public double Sqft { get; set; } // Propiedad metros cuadrados
        [Range(1,10)]
        public int Occupancy { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
    }
}
