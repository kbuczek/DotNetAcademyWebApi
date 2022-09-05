namespace DotNetAcademyWebApi.Entities_Models_
{
    public record Item
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; } //date and time when item got created in the system
    }
}
