using PackIT.Application.DTO;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.EFCore.Queries
{
    public class SearchPackingLists : IQuery<IEnumerable<PackingListDTO>>
    {
        public string SearchPhrase { get; set; } = string.Empty;
    }
}
