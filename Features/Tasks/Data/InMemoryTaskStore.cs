using TaskFlow.CQRS.Api.Features.Tasks.Models;

namespace TaskFlow.CQRS.Api.Features.Tasks.Data;

public static class InMemoryTaskStore
{
    private static readonly List<TaskModel> _tasks = new();
    public static void Add(TaskModel task) => _tasks.Add(task);
    public static IEnumerable<TaskModel> GetAll() => _tasks;
}
