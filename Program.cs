using TaskFlow.CQRS.Api.Features.Tasks.Commands;
using TaskFlow.CQRS.Api.Features.Tasks.Models;
using TaskFlow.CQRS.Api.Features.Tasks.Queries;
using Wolverine;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

// Wolverine handles CQRS, message dispatching, and uses built-in DI
builder.Host.UseWolverine();


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());


// Endpoints
app.MapPost("/tasks", async (CreateTaskCommand command, IMessageBus bus) =>
{
    var id = await bus.InvokeAsync<Guid>(command);
    return Results.Created($"/tasks/{id}", new { Id = id });
});

app.MapGet("/tasks", async (IMessageBus bus) =>
{
    var result = await bus.InvokeAsync<IEnumerable<TaskModel>>(new GetAllTasksQuery());
    return Results.Ok(result);
});


app.Run();
