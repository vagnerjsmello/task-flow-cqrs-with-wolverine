using TaskFlow.CQRS.Api.Features.Tasks.Data;
using TaskFlow.CQRS.Api.Features.Tasks.Models;
namespace TaskFlow.CQRS.Api.Features.Tasks.Commands;


public class CreateTaskCommandHandler
{
    public async Task<Guid> Handle(CreateTaskCommand command)
    {
        var task = new TaskModel(command.Title, command.Description);
        await InMemoryTaskStore.Add(task);
        return task.Id;
    }
}



