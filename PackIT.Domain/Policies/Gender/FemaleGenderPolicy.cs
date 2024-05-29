using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Gender
{
    internal class FemaleGenderPolicy : IPackingItemPolicy
    {
        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Lipstick", 1),
                new("Powder", 1),
                new("Eyeline", 1)
            };

        public bool IsApplicable(PolicyData data)
            => data.Gender is Constant.Gender.Female;
    }
}
