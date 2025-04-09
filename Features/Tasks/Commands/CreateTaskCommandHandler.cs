using TaskFlow.CQRS.Api.Features.Tasks.Data;
using TaskFlow.CQRS.Api.Features.Tasks.Models;
namespace TaskFlow.CQRS.Api.Features.Tasks.Commands;


public class CreateTaskCommandHandler
{
    public Task<Guid> Handle(CreateTaskCommand command, CancellationToken cancellationToken)
    {
        var task = new TaskModel(command.Title, command.Description);
        InMemoryTaskStore.Add(task);
        return Task.FromResult(task.Id);
    }    
}