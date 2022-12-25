namespace DotNetAcademyWebApi.Entities_Models_
{
    //record - used for immutable objects. Have with-expressions support. Value-based equality support.
    public record Item
    {
        public Guid Id { get; init; } //init instead of set. Init-only property
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; } //date and time when item got created in the system
    }
}
