using Microsoft.EntityFrameworkCore;
using PackIT.Application.DTO;
using PackIT.Infrastructure.EFCore.Context;
using PackIT.Infrastructure.EFCore.Models;
using PackIT.Infrastructure.EFCore.Queries;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.EFCore.Queries.Handler
{
    internal sealed class SearchPackingListsHandler : IQueryHandler<SearchPackingLists, IEnumerable<PackingListDTO>>
    {
        private readonly DbSet<PackingListReadModel> _packingLists;

        public SearchPackingListsHandler(ReadDbContext context)
            => _packingLists = context.PackingLists;

        public async Task<IEnumerable<PackingListDTO>> HandleAsync(SearchPackingLists query)
        {
            var dbquery = _packingLists
                .Include(pl => pl.Items)
                .AsQueryable();
            if (query.SearchPhrase is not null)
            {
                dbquery = dbquery.Where(pl =>
                    EF.Functions.Like(pl.Name, $"%{query.SearchPhrase}%"));
            }

            return await dbquery
                .Select(pl => pl.AsDTO())
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
