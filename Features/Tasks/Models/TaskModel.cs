namespace TaskFlow.CQRS.Api.Features.Tasks.Models;

public class TaskModel
{
    public Guid Id { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public DateTime CreatedAt { get; private set; }

    public TaskModel(string title, string description)
    {
        Id = Guid.NewGuid();
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Description = description ?? throw new ArgumentNullException(nameof(description));
        CreatedAt = DateTime.UtcNow;
    }
}

