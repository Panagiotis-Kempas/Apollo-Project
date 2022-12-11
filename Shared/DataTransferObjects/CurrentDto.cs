namespace Shared.DataTransferObjects
{
    public class CurrentDto
    {
        public string? Id { get; set; }
        public double Amount { get; set; }
        public string CreditDebitIndicator { get; set; }
        public IEnumerable<CurrentCreditLineDto> CreditLines { get; set; }
    }
}