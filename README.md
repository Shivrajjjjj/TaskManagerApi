
# 📋 TaskManagerApi

A modern, full-stack **Task Management Web App** built with **ASP.NET Core Web API** and **Bootstrap 5**. It allows users to create, read, update, and delete tasks, with a clean and responsive interface. A dashboard summarizes task data and status.

---

## 🚀 Features

- ✅ Create, view, update, and delete tasks
- 📊 Dashboard with task analytics
- 🔍 Fetch all tasks with dynamic data rendering
- 🖥️ Clean and responsive UI using Bootstrap 5
- 🌐 Navigation between all pages

---

## 🛠️ Tech Stack

- **Backend**: ASP.NET Core Web API
- **Frontend**: HTML5, Bootstrap 5, JavaScript
- **Database**: In-memory / SQL Server (via Entity Framework Core)

---

## 📁 Project Structure

```
/TaskManagerApi
├── Controllers/
│   ├── TaskItemsController.cs
│   └── PagesController.cs
├── wwwroot/
│   ├── index.html
│   ├── create.html
│   ├── tasks.html
│   ├── update.html
│   ├── delete.html
│   └── dashboard.html
├── Models/
│   └── TaskItem.cs
├── Program.cs
└── README.md
```

---

## 🚦 How to Run

1. **Clone the Repository**
   ```bash
   git clone https://github.com/yourusername/TaskManagerApi.git
   cd TaskManagerApi
   ```

2. **Run the Application**
   ```bash
   dotnet run
   ```

3. **Open in Browser**
   ```
   http://localhost:7261/pages/index
   ```

---

## 🌐 Web Pages

| Page        | URL                        | Description             |
|-------------|----------------------------|-------------------------|
| 🏠 Home      | `/pages/index`             | Landing task list page  |
| ➕ Create    | `/pages/create`            | Add new task            |
| 📋 Tasks     | `/pages/tasks`             | View all tasks          |
| ✏️ Update    | `/pages/update`            | Edit existing tasks     |
| ❌ Delete    | `/pages/delete`            | Remove tasks            |
| 📊 Dashboard | `/pages/dashboard`         | Visual summary of tasks |

---

## 🔌 API Endpoints

| Method | Endpoint             | Description       |
|--------|----------------------|-------------------|
| GET    | `/api/taskitems`     | Get all tasks     |
| GET    | `/api/taskitems/{id}`| Get task by ID    |
| POST   | `/api/taskitems`     | Add new task      |
| PUT    | `/api/taskitems/{id}`| Update a task     |
| DELETE | `/api/taskitems/{id}`| Delete a task     |

---

