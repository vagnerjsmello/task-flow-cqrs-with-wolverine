using TaskFlow.CQRS.Api.Common;

namespace TaskFlow.CQRS.Api.Dispatchers;

/// <summary>
/// Implementation of IQueryDispatcher that uses dependency injection
/// to find and execute the appropriate query handler.
/// </summary>
public class QueryDispatcher(IServiceProvider serviceProvider) : IQueryDispatcher
{
    private readonly IServiceProvider _serviceProvider = serviceProvider;

    public Task<TQueryResult> Dispatch<TQuery, TQueryResult>(TQuery query, CancellationToken cancellationToken)
    {
        var handler = _serviceProvider.GetRequiredService<IQueryHandler<TQuery, TQueryResult>>();
        return handler.Handle(query, cancellationToken);
    }
}
