using PackIT.Application.DTO;
using PackIT.Infrastructure.EFCore.Models;

namespace PackIT.Infrastructure.EFCore.Queries
{
    internal static class Extensions
    {
        public static PackingListDTO AsDTO(this PackingListReadModel readModel)
            => new()
            {
                Id = readModel.Id,
                Name = readModel.Name,
                Localization = new LocalizationDTO
                {
                    City = readModel.Localization?.City,
                    Country = readModel.Localization?.Country,
                },
                Items = readModel.Items?.Select(pi => new PackingItemDTO
                {
                    Name = pi.Name,
                    Quantity = pi.Quantity,
                    IsPacked = pi.IsPacked
                })
            };
    }
}
