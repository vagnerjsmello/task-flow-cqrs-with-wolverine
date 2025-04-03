namespace TaskFlow.CQRS.Api.Common;

/// <summary>
/// Dispatches a query to its appropriate query handler.
/// </summary>
public interface IQueryDispatcher
{
    Task<TQueryResult> Dispatch<TQuery, TQueryResult>(TQuery query, CancellationToken cancellationToken);
}