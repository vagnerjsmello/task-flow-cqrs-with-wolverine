using TaskFlow.CQRS.Api.Common;
using TaskFlow.CQRS.Api.Features.Tasks.Models;

namespace TaskFlow.CQRS.Api.Features.Tasks.Commands;


public class CreateTaskCommandHandler : ICommandHandler<CreateTaskCommand, Guid>
{
    private static readonly List<TaskModel> _tasks = new();

    public Task<Guid> Handle(CreateTaskCommand command, CancellationToken cancellationToken)
    {
        var task = new TaskModel
        {
            Id = Guid.NewGuid(),
            Title = command.Title,
            Description = command.Description,
            CreatedAt = DateTime.UtcNow
        };

        _tasks.Add(task);
        return Task.FromResult(task.Id);
    }

    public static List<TaskModel> GetTasks() => _tasks;
}