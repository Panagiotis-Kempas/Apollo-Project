namespace Shared.DataTransferObjects
{
    public class EnrichedDataDto
    {
        public string? Id { get; set; }
        public CategoryDto Category { get; set; }
        public ClassDto Class { get; set; }
        public string? PredictedMerchantName { get; set; }
    }
}