using TaskFlow.CQRS.Api.Common;
using TaskFlow.CQRS.Api.Dispatchers;
using TaskFlow.CQRS.Api.Features.Tasks.Commands;
using TaskFlow.CQRS.Api.Features.Tasks.Models;
using TaskFlow.CQRS.Api.Features.Tasks.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

//Services
builder.Services.AddScoped<ICommandDispatcher, CommandDispatcher>();
builder.Services.AddScoped<IQueryDispatcher, QueryDispatcher>();

builder.Services.AddScoped<ICommandHandler<CreateTaskCommand, Guid>, CreateTaskCommandHandler>();
builder.Services.AddScoped<IQueryHandler<GetAllTasksQuery, IEnumerable<TaskModel>>, GetAllTasksQueryHandler>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Endpoints
app.MapPost("/tasks", async (CreateTaskCommand command, ICommandDispatcher dispatcher, CancellationToken ct) =>
{
    var id = await dispatcher.Dispatch<CreateTaskCommand, Guid>(command, ct);
    return Results.Created($"/tasks/{id}", new { Id = id });
});

app.MapGet("/tasks", async (IQueryDispatcher dispatcher, CancellationToken ct) =>
{
    var result = await dispatcher.Dispatch<GetAllTasksQuery, IEnumerable<TaskModel>>(new(), ct);
    return Results.Ok(result);
});

app.Run();
