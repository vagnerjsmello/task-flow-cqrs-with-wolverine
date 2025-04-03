namespace TaskFlow.CQRS.Api.Features.Tasks.Commands;

public record CreateTaskCommand(string Title, string Description);
