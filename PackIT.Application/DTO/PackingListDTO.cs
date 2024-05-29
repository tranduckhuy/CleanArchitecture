using PackIT.Domain.ValueObjects;

namespace PackIT.Application.DTO
{
    public class PackingListDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public LocalizationDTO Localization { get; set; } = null!;
        public IEnumerable<PackingItemDTO>? Items { get; set; }
    }
}
