namespace PackIT.Application.DTO
{
    public class PackingItemDTO
    {
        public string Name { get; set; } = string.Empty;
        public uint Quantity { get; set; }
        public bool IsPacked { get; set; }
    }
}
