using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;


namespace Apollo
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<Account, AccountDto>();
            CreateMap<Identifier, IdentifierDto>();
            CreateMap<Party, PartyDto>();
            CreateMap<Address, AddressDto>();
            CreateMap<PhoneNumber, PhoneNumberDto>();
            CreateMap<Balance, BalanceDto>();
            CreateMap<Current, CurrentDto>();
            CreateMap<Available, AvailableDto>();
            CreateMap<AvailableCreditLine, AvailableCreditLineDto>();
            CreateMap<CurrentCreditLine, CurrentCreditLineDto>();
            CreateMap<Transaction, TransactionDto>();
            CreateMap<TransactionCode, TransactionCodeDto>();
            CreateMap<MerchantDetails, MerchantDetailsDto>();
            CreateMap<EnrichedData, EnrichedDataDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Class, ClassDto>();

            CreateMap<AccountDto, Account>().ForMember(x => x.AccountId, opt => opt.MapFrom(x => x.AccountId == null ? Guid.NewGuid().ToString() : x.AccountId.ToString()));

            CreateMap<CustomerDto, Customer>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString()));

            CreateMap<IdentifierDto, Identifier>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString()));

            CreateMap<PartyDto, Party>().ForMember(x => x.PartyId, opt => opt.MapFrom(x => x.PartyId == null ? Guid.NewGuid().ToString() : x.PartyId.ToString()));

            CreateMap<AddressDto, Address>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString()));

            CreateMap<PhoneNumberDto, PhoneNumber>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString()));

            CreateMap<BalanceDto, Balance>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString()));

            CreateMap<CurrentDto, Current>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString()));

            CreateMap<AvailableDto, Available>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString())); 

            CreateMap<AvailableCreditLineDto, AvailableCreditLine>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString()));

            CreateMap<CurrentCreditLineDto, CurrentCreditLine>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString()));

            CreateMap<TransactionDto, Transaction>()
                .ForMember(x => x.BookingDate, opt => opt.MapFrom(x => DateTime.Parse(x.BookingDate).ToShortDateString()))
                .ForMember(x => x.TransactionId, opt => opt.MapFrom(x => x.TransactionId == null ? Guid.NewGuid().ToString() : x.TransactionId.ToString()));

            CreateMap<TransactionCodeDto, TransactionCode>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString()));

            CreateMap<MerchantDetailsDto, MerchantDetails>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString()));

            CreateMap<EnrichedDataDto, EnrichedData>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id == null ? Guid.NewGuid().ToString() : x.Id.ToString()));

            CreateMap<CategoryDto, Category>().ForMember(x => x.CategoryId, opt => opt.MapFrom(x => x.CategoryId == null ? Guid.NewGuid().ToString() : x.CategoryId.ToString()));

            CreateMap<ClassDto, Class>().ForMember(x => x.ClassId, opt => opt.MapFrom(x => x.ClassId == null ? Guid.NewGuid().ToString() : x.ClassId.ToString()));
        }
    }
}
