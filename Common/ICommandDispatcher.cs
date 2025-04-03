namespace TaskFlow.CQRS.Api.Common;

/// <summary>
/// Dispatches a command to its appropriate command handler.
/// </summary>
public interface ICommandDispatcher
{
    Task<TCommandResult> Dispatch<TCommand, TCommandResult>(TCommand command, CancellationToken cancellationToken);
}
