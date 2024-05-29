using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Gender
{
    internal class MaleGenderPolicy : IPackingItemPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Laptop", 1),
                new("Beer", 10),
                new("Book", (uint) Math.Ceiling(data.Days/7m))
            };

        public bool IsApplicable(PolicyData data)
            => data.Gender is Constant.Gender.Male;
    }
}
