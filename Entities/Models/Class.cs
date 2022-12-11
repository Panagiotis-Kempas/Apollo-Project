using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Class
    {
        [Column("ClassId")]
        [Key]
        public string ClassId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Confidence { get; set; }
        public string EnrichedDataId { get; set; }
        public EnrichedData EnrichedData { get; set; }
    }
}