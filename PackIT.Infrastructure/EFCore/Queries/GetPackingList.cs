using PackIT.Application.DTO;
using PackIT.Infrastructure.EFCore.Models;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.EFCore.Queries
{
    public class GetPackingList : IQuery<PackingListDTO>
    {
        public Guid Id { get; set; }
    }

}
