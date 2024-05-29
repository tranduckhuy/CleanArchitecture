using PackIT.Domain.Constant;
using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application
{
    public record CreatePackingListWithItems(Guid Id, string Name, ushort Days, Gender Gender,
        LocalizationWriteModel Localization) : ICommand;


    public record LocalizationWriteModel(string City, string Country);
}
