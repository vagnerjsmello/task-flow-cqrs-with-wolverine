# Task Flow CQRS with Wolverine 🧠⚡

This is a simple example using **CQRS (Command Query Responsibility Segregation)**  
with **.NET 9 Minimal API** and **Wolverine** for message handling.

> ⚠️ **Note:** This project does not use MediatR.  
> Instead, it uses [Wolverine](https://wolverine.netlify.app/) – a free and powerful alternative.

---

### ✨ Technologies

- [.NET 9](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- C# 13
- Minimal API
- CQRS Pattern
- [Wolverine](https://wolverine.netlify.app/)
- OpenAPI (native from .NET 9)

---

### 📁 Project Structure

``` bash
TaskFlow.CQRS.Api/
│
├── Features/
│   └── Tasks/
│       ├── Commands/          # CreateTaskCommand and its handler
│       ├── Queries/           # GetAllTasksQuery and its handler
│       ├── Models/            # TaskModel class
│       └── Data/              # In-memory task store
│
├── Program.cs                 # API configuration with Wolverine and OpenAPI
└── README.md
```

---

### 🚀 How to Run

1. Clone the project:

   ```bash
   git clone https://github.com/your-username/task-flow-cqrs-with-wolverine.git
   cd task-flow-cqrs-with-wolverine
   ```

2. Run the project:

   ```bash
   dotnet run
   ```

3. Open this link to see the API documentation:

   ```
   https://localhost:7236/openapi/v1.json
   ```

---

### 📄 API Documentation

This project uses **OpenAPI from .NET 9**.

There is no Swagger UI in this project, but you can use the Swagger Editor online:

1. Go to: [https://editor.swagger.io](https://editor.swagger.io)
2. Paste this link:
   ```
   https://localhost:5001/openapi/v1.json
   ```

---

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

---

## 🎯 Goal

This project is for learning.  
It shows how to use the CQRS pattern with Minimal API and Wolverine.

You can use it to learn, build new features, or start other projects.

---

## 📄 License

This project uses the [MIT License](LICENSE).
