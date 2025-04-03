using TaskFlow.CQRS.Api.Common;
using TaskFlow.CQRS.Api.Features.Tasks.Commands;
using TaskFlow.CQRS.Api.Features.Tasks.Models;

namespace TaskFlow.CQRS.Api.Features.Tasks.Queries;



public class GetAllTasksQueryHandler : IQueryHandler<GetAllTasksQuery, IEnumerable<TaskModel>>
{
    public Task<IEnumerable<TaskModel>> Handle(GetAllTasksQuery query, CancellationToken cancellationToken)
    {
        var tasks = CreateTaskCommandHandler.GetTasks();
        return Task.FromResult(tasks.AsEnumerable());
    }
}