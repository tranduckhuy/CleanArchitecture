using Microsoft.Extensions.DependencyInjection;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Shared.Queries
{
    public class InMemoryQueryDispatcher : IQueryDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public InMemoryQueryDispatcher(IServiceProvider serviceProvider)
            => _serviceProvider = serviceProvider;

        public async Task<TResult> QueryAsync<TResult>(IQuery<TResult> query)
        {
            using var scope = _serviceProvider.CreateScope();
            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));
            var handler = scope.ServiceProvider.GetRequiredService(handlerType);

            var handleMethod = handlerType.GetMethod(nameof(IQueryHandler<IQuery<TResult>, TResult>.HandleAsync));

            if (handleMethod is null)
            {
                throw new InvalidOperationException($"HandleAsync method not found for query type: {query.GetType()}");
            }

            var resultTask = (Task<TResult>)handleMethod.Invoke(handler, new[] { query })!;
            return await resultTask;
        }
    }
}
