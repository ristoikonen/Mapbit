﻿namespace Mapbit.Abstractions.Queries
{
    //  internal sealed class
    public class InMemoryQueryDispatcher
    {
        private readonly IServiceProvider _serviceProvider;
        /*
        public async Task<TResult> QueryAsync<TResult>(IQuery<TResult> query)
        {
            using var scope = _serviceProvider.CreateScope();
            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));
            var handler = scope.ServiceProvider.GetRequiredService(handlerType);

            return await (Task<TResult>)handlerType.GetMethod(nameof(IQueryHandler<IQuery<TResult>, TResult>.HandleAsync))?
                .Invoke(handler, new[] { query });
        }
        */
    }
}
