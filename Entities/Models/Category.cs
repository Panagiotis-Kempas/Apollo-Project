using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Category
    {
        [Column("CategoryId")]
        [Key]
        public string CategoryId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Confidence { get; set; }
        public string EnrichedDataId { get; set; }
        public EnrichedData EnrichedData { get; set; }
    }
}