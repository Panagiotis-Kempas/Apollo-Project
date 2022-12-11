using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Party
    {
        [Column("PartyId")]
        public string PartyId { get; set; }
        public string FullName { get; set; }
        public string? PartyType { get; set; }
        public bool? IsIndividual { get; set; }
        public bool? IsAuthorizingParty { get; set; }
        public string? EmailAddress { get; set; }


        //Navigation Properties
        public ICollection<Address> Addresses { get; set; }
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public string AccountId { get; set; }
        public Account Account { get; set; }
    }
}
