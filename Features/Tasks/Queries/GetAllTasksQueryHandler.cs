using TaskFlow.CQRS.Api.Features.Tasks.Commands;
using TaskFlow.CQRS.Api.Features.Tasks.Data;
using TaskFlow.CQRS.Api.Features.Tasks.Models;

namespace TaskFlow.CQRS.Api.Features.Tasks.Queries;



public class GetAllTasksQueryHandler 
{
    public Task<IEnumerable<TaskModel>> Handle(GetAllTasksQuery query, CancellationToken cancellationToken) 
        => Task.FromResult(InMemoryTaskStore.GetAll());    
}