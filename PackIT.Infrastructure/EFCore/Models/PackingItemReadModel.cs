namespace PackIT.Infrastructure.EFCore.Models
{
    public class PackingItemReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public uint Quantity { get; set; }
        public bool IsPacked { get; set; }

        public PackingListReadModel PackingList { get; set; } = null!;
    }
}
