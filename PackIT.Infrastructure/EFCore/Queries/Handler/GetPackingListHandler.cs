using Microsoft.EntityFrameworkCore;
using PackIT.Application.DTO;
using PackIT.Infrastructure.EFCore.Context;
using PackIT.Infrastructure.EFCore.Models;
using PackIT.Infrastructure.EFCore.Queries;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.EFCore.Queries.Handler
{
    internal sealed class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDTO>
    {
        private readonly DbSet<PackingListReadModel> _packingLists;

        public GetPackingListHandler(ReadDbContext context)
            => _packingLists = context.PackingLists;

        public Task<PackingListDTO> HandleAsync(GetPackingList query)
            => _packingLists
                .Include(pl => pl.Items)
                .Where(pl => pl.Id == query.Id)
                .Select(pl => pl.AsDTO())
                .AsNoTracking()
                .SingleOrDefaultAsync()!;
    }
}
