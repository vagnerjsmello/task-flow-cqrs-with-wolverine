namespace TaskFlow.CQRS.Api.Common;

/// <summary>
/// Handles a command and returns a result.
/// </summary>
/// <typeparam name="TCommand">The command type.</typeparam>
/// <typeparam name="TCommandResult">The result type returned after handling the command.</typeparam>
public interface ICommandHandler<in TCommand, TCommandResult>
{
    Task<TCommandResult> Handle(TCommand command, CancellationToken cancellationToken);
}
