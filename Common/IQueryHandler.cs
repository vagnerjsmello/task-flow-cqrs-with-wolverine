namespace TaskFlow.CQRS.Api.Common;

/// <summary>
/// Handles a query and returns a result.
/// </summary>
/// <typeparam name="TQuery">The query type.</typeparam>
/// <typeparam name="TQueryResult">The result type returned after handling the query.</typeparam>
public interface IQueryHandler<in TQuery, TQueryResult>
{
    Task<TQueryResult> Handle(TQuery query, CancellationToken cancellationToken);
}
