using TaskFlow.CQRS.Api.Features.Tasks.Models;

namespace TaskFlow.CQRS.Api.Features.Tasks.Data;

public static class InMemoryTaskStore
{
    private static readonly List<TaskModel> _tasks = new();

    public static async Task Add(TaskModel task) => await Task.Run(() => _tasks.Add(task));

    public static async Task<IEnumerable<TaskModel>> GetAll() => await Task.FromResult(_tasks);
    
}
