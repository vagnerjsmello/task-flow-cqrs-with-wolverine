# Task Flow CQRS Without MediatR 🧠✅

This is a simple example of **CQRS (Command Query Responsibility Segregation)**.  
It uses **.NET 9 Minimal API** and no external libraries.

This project is a small **task manager API** (like a to-do list).  
It uses **commands** to create tasks and **queries** to get tasks.

> ⚠️ **Note:** This project **does not use MediatR**.  
> MediatR will be a **paid library**, so we use a simple and free solution.

### ✨ Technologies

- [.NET 9](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- C# 13
- Minimal API
- CQRS pattern
- OpenAPI (native from .NET 9)

### 📁 Project Structure

```
TaskFlow.CQRS/
│
├── Common/                # Interfaces for Commands and Queries
├── Dispatchers/           # Logic to call the correct handler
├── Features/
│   └── Tasks/             # Task logic
│       ├── Commands/      # Write operations
│       ├── Queries/       # Read operations
│       └── Models/        # Task data
├── Program.cs             # API configuration
└── README.md
```

### 🚀 How to Run

1. Clone the project:

   ```bash
   git clone https://github.com/your-username/TaskFlow.CQRS.git
   cd TaskFlow.CQRS
   ```

2. Run the project:

   ```bash
   dotnet run
   ```

3. Open this link to see the API documentation:

   ```
   https://localhost:5001/openapi/v1.json
   ```

### 📄 API Documentation

This project uses **OpenAPI from .NET 9**.  
There is no Swagger UI inside the project.

To see the API in Swagger UI:

1. Go to [https://editor.swagger.io](https://editor.swagger.io)  
2. Copy and paste this link:

   ```
   https://localhost:7236/openapi/v1.json
   or
   http://localhost:7237/openapi/v1.json
   ```

### 🛠️ Example Endpoints

#### Create a new task

`POST /tasks`

```json
{
  "title": "Study CQRS",
  "description": "Create a small example using Minimal API"
}
```

#### Get all tasks

`GET /tasks`

## 📌 Goal

This project is for learning.  
It shows how to use the CQRS pattern in a modern and simple way with .NET.

You can use it to study or as a starting point for bigger projects.

## 📄 License

This project uses the [MIT License](LICENSE).
