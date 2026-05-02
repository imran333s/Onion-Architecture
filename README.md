# 🧅 Onion Architecture in .NET Core – Clean Template

## 📌 Overview

This project demonstrates a **Clean Onion Architecture** implementation using ASP.NET Core.

It is designed to help developers build **scalable, maintainable, and testable** applications by separating concerns into multiple layers.

---

## 🏗️ Architecture Structure

The project follows Onion Architecture with these layers:

```
OnionDemo
│
├── OnionDemo.Domain        → Core business entities & interfaces
├── OnionDemo.Application   → Business logic (services, DTOs)
├── OnionDemo.Infrastructure → Database, external services (EF Core, Dapper)
├── OnionDemo.API           → Web API (Controllers, endpoints)
```

---

## 🔥 Technologies Used

* ASP.NET Core Web API
* .NET 8 / .NET 10
* Entity Framework Core
* SQL Server
* Dapper
* Clean Architecture Principles
* Dependency Injection

---

## ⚙️ Prerequisites

Before running this project, make sure you have:

* .NET SDK installed
* SQL Server installed
* Visual Studio or VS Code

---

## 🚀 Getting Started

### 1️⃣ Clone the repository

```
git clone https://github.com/your-username/Onion-Architecture.git
cd Onion-Architecture
```

---

### 2️⃣ Configure Database

Update connection string in:

```
appsettings.json
```

Example:

```
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=OnionDb;Trusted_Connection=True;"
}
```

---

### 3️⃣ Apply Migrations

```
dotnet ef database update
```

---

### 4️⃣ Run the project

```
dotnet run --project OnionDemo.API
```

---

## 📡 API Endpoints

Example:

```
GET    /api/students
POST   /api/students
PUT    /api/students/{id}
DELETE /api/students/{id}
```

---

## 🧠 Key Concepts

* **Domain Layer** → No dependency on other layers
* **Application Layer** → Contains business logic
* **Infrastructure Layer** → Handles database & external services
* **API Layer** → Entry point (controllers)

---

## ❗ Important Notes

* `bin/`, `obj/`, `.vs/` are excluded using `.gitignore`
* Follow dependency rule:
  👉 Outer layers depend on inner layers only

---

## 👨‍💻 How to Extend (for Juniors)

1. Add new Entity → Domain Layer
2. Create Interface → Application Layer
3. Implement Repository → Infrastructure
4. Add Controller → API Layer

---

## 📚 Learning Purpose

This project is ideal for:

* Beginners learning Clean Architecture
* .NET Developers preparing for interviews
* Building scalable enterprise apps

---

## 🤝 Contribution

Feel free to fork and improve this project.

---

## 📧 Contact

Created by **Imran**
If you have questions, feel free to reach out.

---

⭐ If this helped you, don’t forget to star the repo!
