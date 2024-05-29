using PackIT.Application.DTO;
using PackIT.Domain.ValueObjects;

namespace PackIT.Application.Services
{
    public interface IPackingListReadService
    {
        Task<bool> ExistsByNameAsync(string name);

    }
}
