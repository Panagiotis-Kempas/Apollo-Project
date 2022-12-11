namespace Shared.DataTransferObjects
{
    public class AvailableDto
    {
        public string? Id { get; set; }
        public double Amount { get; set; }
        public string CreditDebitIndicator { get; set; }
        public IEnumerable<AvailableCreditLineDto> CreditLines { get; set; }
    }
}