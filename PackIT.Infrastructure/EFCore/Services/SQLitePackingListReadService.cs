using Microsoft.EntityFrameworkCore;
using PackIT.Application.DTO;
using PackIT.Application.Services;
using PackIT.Domain.ValueObjects;
using PackIT.Infrastructure.EFCore.Context;
using PackIT.Infrastructure.EFCore.Models;

namespace PackIT.Infrastructure.EFCore.Services
{
    internal sealed class SQLitePackingListReadService : IPackingListReadService
    {
        private readonly DbSet<PackingListReadModel> _packingList;

        public SQLitePackingListReadService(ReadDbContext context)
            => _packingList = context.PackingLists;

        public Task<bool> ExistsByNameAsync(string name)
            => _packingList.AnyAsync(pl => pl.Name == name);
    }
}
