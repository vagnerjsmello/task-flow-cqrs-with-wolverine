using TaskFlow.CQRS.Api.Common;

namespace TaskFlow.CQRS.Api.Dispatchers;

/// <summary>
/// Implementation of ICommandDispatcher that uses dependency injection
/// to find and execute the appropriate command handler.
/// </summary>
public class CommandDispatcher(IServiceProvider serviceProvider) : ICommandDispatcher
{
    private readonly IServiceProvider _serviceProvider = serviceProvider;

    public Task<TCommandResult> Dispatch<TCommand, TCommandResult>(TCommand command, CancellationToken cancellationToken)
    {
        var handler = _serviceProvider.GetRequiredService<ICommandHandler<TCommand, TCommandResult>>();
        return handler.Handle(command, cancellationToken);
    }
}
