using PackIT.Application.Exceptions;
using PackIT.Domain.Repositories;
using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands.Handler
{
    internal sealed class RemovePackingListHandler : ICommandHandler<DeletePackingList>
    {
        private readonly IPackingListRepository _repository;

        public RemovePackingListHandler(IPackingListRepository repository)
        {
            _repository = repository;
        }

        public async Task HandleAsync(DeletePackingList command)
        {
            var packingList = await _repository.GetAsync(command.PackingListId);
            if (packingList is null)
            {
                throw new PackingListNotFoundException(command.PackingListId);
            }

            await _repository.DeleteAsync(packingList);
        }
    }
}
