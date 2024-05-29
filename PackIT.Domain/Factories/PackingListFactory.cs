﻿using PackIT.Domain.Constant;
using PackIT.Domain.Entities;
using PackIT.Domain.Policies;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Factories
{
    public sealed class PackingListFactory : IPackingListFactory
    {
        private readonly IEnumerable<IPackingItemPolicy> _policies;

        public PackingListFactory(IEnumerable<IPackingItemPolicy> policies)
            => _policies = policies;

        public PackingList Create(PackingListId id, PackingListName name, Localization localization)
            => new(id, name, localization);

        public PackingList CreateWithDefaultItems(PackingListId id, PackingListName name, TravelDays days, Gender gender,
            Temperature temperature, Localization localization)
        {
            var data = new PolicyData(days,temperature, localization, gender);
            var applicablePolicies = _policies.Where(p => p.IsApplicable(data));

            var items = applicablePolicies.SelectMany(p => p.GenerateItems(data));
            var packingList = Create(id, name, localization);

            packingList.AddItems(items);

            return packingList;
        }
    }
}
