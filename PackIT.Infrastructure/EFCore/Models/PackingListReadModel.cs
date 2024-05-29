
namespace PackIT.Infrastructure.EFCore.Models
{
    public class PackingListReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Version { get; set; }
        public LocalizationReadModel Localization { get; set; } = null!;
        public ICollection<PackingItemReadModel>? Items { get; set; }
    }
}
