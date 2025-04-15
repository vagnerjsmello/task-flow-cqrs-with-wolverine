using TaskFlow.CQRS.Api.Features.Tasks.Data;
using TaskFlow.CQRS.Api.Features.Tasks.Models;

namespace TaskFlow.CQRS.Api.Features.Tasks.Queries;



public class GetAllTasksQueryHandler
{
    public async Task<IEnumerable<TaskModel>> Handle(GetAllTasksQuery query)
        => await InMemoryTaskStore.GetAll();
}



