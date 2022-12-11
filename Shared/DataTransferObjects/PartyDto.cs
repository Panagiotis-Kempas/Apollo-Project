using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class PartyDto
    {
        public string PartyId { get; set; }
        public string FullName { get; set; }
        public string? PartyType { get; set; }
        public bool? IsIndividual { get; set; }
        public bool? IsAuthorizingParty { get; set; }
        public string? EmailAddress { get; set; }

        public IEnumerable<AddressDto> Addresses { get; set; }
        public IEnumerable<PhoneNumberDto> PhoneNumbers { get; set; }
    }
}
