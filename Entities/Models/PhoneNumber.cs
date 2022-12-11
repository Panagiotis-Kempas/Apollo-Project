using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class PhoneNumber
    {
        [Column("PhoneNumberId")]
        public string Id { get; set; }
        public string PartyId { get; set; }
        public Party Party { get; set; }
    }
}