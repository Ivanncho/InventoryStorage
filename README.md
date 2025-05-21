# 🛍️ Product Management Application

A full-stack web application for managing products using **.NET 9 Web API**, **Angular**, and **SQL Server**.

---

## 📦 Features

- ✅ View all products in a table
- ➕ Add new products
- 📝 Edit existing products
- 🔍 View product details
- ❌ Delete products
- ✔️ Reactive form validations
- 🗄️ SQL Server integration
- 🧪 Swagger API documentation
- 🚀 Docker support (SQL Server)

---

## 🧰 Technologies Used

| Backend      | Frontend | Database   | Other Tools       |
|--------------|----------|------------|--------------------|
| .NET 9       | Angular 17 | SQL Server | Swagger, Docker     |
| ASP.NET Core | TypeScript | EF Core    | Visual Studio Code |

---

## 🔧 Project Structure

```
ProductManagementApp/
├── Backend/        → .NET 8 Web API
└── Frontend/       → Angular App
```

---

## ⚙️ Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/)
- [Node.js & npm](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)

---

## 🛠️ Setup Instructions

### 🔙 Backend (ASP.NET Core)

1. Navigate to the backend directory:

   ```bash
   cd InventoryAPI
   ```

2. Restore dependencies:

   ```bash
   dotnet restore
   ```

3. Update the SQL Server connection string in `appsettings.json`:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost,1433;Database=ProductDb;User Id=sa;Password=Your_password123;TrustServerCertificate=True;"
   }
   ```

4. Apply migrations and create the database:

   ```bash
   dotnet ef database update
   ```

5. Run the API:

   ```bash
   dotnet run
   ```

6. API will be available at: `https://localhost:Yourport/api/product`

---

### 🖥️ Frontend (Angular)

1. Navigate to the frontend directory:

   ```bash
   cd InventoryUI
   ```

2. Install dependencies:

   ```bash
   npm install
   ```

3. Run the Angular app:

   ```bash
   ng serve
   ```

4. Open in browser: `http://localhost:4200`

---

## 🔁 API Endpoints

| Method | Endpoint           | Description            |
|--------|--------------------|------------------------|
| GET    | /api/product      | Get all products       |
| GET    | /api/product/{id} | Get product by ID      |
| POST   | /api/product      | Add new product        |
| PUT    | /api/product/{id} | Update product         |
| DELETE | /api/product/{id} | Delete product         |

Swagger available at: `https://localhost:Yourport/swagger`

---

## 📸 UI Screenshots

> Coming soon...

---

## 🪪 License

This project is licensed under the [MIT License](LICENSE).
