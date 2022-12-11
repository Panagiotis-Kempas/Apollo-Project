namespace Shared.DataTransferObjects
{
    public class IdentifierDto
    {
        public string? Id { get; set; }
        public string AccountNumber { get; set; }
        public string BankCode { get; set; }
        public string? Iban { get; set; }
        public string? SecondaryIdentification { get; set; }
    }
}