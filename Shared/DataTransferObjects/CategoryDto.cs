namespace Shared.DataTransferObjects
{
    public class CategoryDto
    {
        public string? CategoryId { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public double Confidence { get; set; }
    }
}