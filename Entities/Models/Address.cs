using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Address
    {
        [Column("AddressId")]
        public string Id { get; set; }
        public string PartyId { get; set; }
        public Party Party { get; set; }
    }
}