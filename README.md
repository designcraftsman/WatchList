# WatchList

WatchList is a web application built using ASP.NET Core MVC for managing and tracking movies. It allows users to create, edit, and view lists of films, as well as manage user accounts and interactions.

## Features

### Film Management
- **CRUD Operations**: Create, read, update, and delete films.
- **Film Lists**: Organize films into lists for easy tracking.
- **Search and Filter**: Search films by title, genre, or other criteria.

### User Management
- **Authentication**: Secure login and registration using ASP.NET Identity.
- **Role-Based Access**: Different roles such as Admin and User.
- **Profile Management**: Manage user profiles and preferences.

### Responsive Design
- **Bootstrap Integration**: Styled using Bootstrap for responsive layouts.
- **Scoped CSS**: Custom styles scoped to specific components.

### Database Integration
- **Entity Framework Core**: Used for database interactions.
- **Migrations**: Manage schema changes with migrations.

## Technologies Used

### Backend
- **ASP.NET Core MVC**: Framework for building web applications.
- **Entity Framework Core**: ORM for database operations.
- **SQL Server**: Database for storing film and user data.

### Frontend
- **Razor Views**: Dynamic HTML rendering.
- **Bootstrap**: Responsive design framework.
- **jQuery**: Frontend interactivity.

### Tools
- **Scoped CSS**: Scoped styles for specific views.
- **Static Web Assets**: Manage static files like CSS and JavaScript.

## MVC Architecture

The project follows the Model-View-Controller (MVC) design pattern:

- **Model**: Represents the data and business logic. For example, `Film`, `User`, and `FilmUser` models define the structure of the database entities.
- **View**: Handles the user interface. Razor views in the `Views` directory render dynamic content.
- **Controller**: Acts as the intermediary between the Model and View. Controllers like `FilmsController` and `HomeController` process user input and return responses.

## Project Structure

```
WatchList/
├── WatchList.sln
├── appsettings.json
├── Program.cs
├── Areas/
│   └── Identity/
├── Controllers/
│   ├── FilmListController.cs
│   ├── FilmsController.cs
│   ├── HomeController.cs
├── Data/
│   ├── ApplicationDbContext.cs
│   ├── Film.cs
│   ├── FilmUser.cs
│   ├── User.cs
├── Migrations/
│   ├── 20241215160242_first.cs
│   ├── 20241215160242_first.Designer.cs
│   ├── 20241215162234_user.cs
├── Models/
├── Views/
├── wwwroot/
│   ├── css/
│   ├── js/
│   ├── lib/
```

## How to Run

1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```
2. Set up a SQL Server database and update the connection string in `appsettings.json`.
3. Apply migrations to the database:
   ```bash
   dotnet ef database update
   ```
4. Run the application:
   ```bash
   dotnet run
   ```
5. Open the application in your browser at `http://localhost:5000`.

Let me know if you need further adjustments!# WatchList

WatchList is a web application built using ASP.NET Core MVC for managing and tracking movies. It allows users to create, edit, and view lists of films, as well as manage user accounts and interactions.

## Features

### Film Management
- **CRUD Operations**: Create, read, update, and delete films.
- **Film Lists**: Organize films into lists for easy tracking.
- **Search and Filter**: Search films by title, genre, or other criteria.

### User Management
- **Authentication**: Secure login and registration using ASP.NET Identity.
- **Role-Based Access**: Different roles such as Admin and User.
- **Profile Management**: Manage user profiles and preferences.

### Responsive Design
- **Bootstrap Integration**: Styled using Bootstrap for responsive layouts.
- **Scoped CSS**: Custom styles scoped to specific components.

### Database Integration
- **Entity Framework Core**: Used for database interactions.
- **Migrations**: Manage schema changes with migrations.

## Technologies Used

### Backend
- **ASP.NET Core MVC**: Framework for building web applications.
- **Entity Framework Core**: ORM for database operations.
- **SQL Server**: Database for storing film and user data.

### Frontend
- **Razor Views**: Dynamic HTML rendering.
- **Bootstrap**: Responsive design framework.
- **jQuery**: Frontend interactivity.

### Tools
- **Scoped CSS**: Scoped styles for specific views.
- **Static Web Assets**: Manage static files like CSS and JavaScript.

## MVC Architecture

The project follows the Model-View-Controller (MVC) design pattern:

- **Model**: Represents the data and business logic. For example, `Film`, `User`, and `FilmUser` models define the structure of the database entities.
- **View**: Handles the user interface. Razor views in the `Views` directory render dynamic content.
- **Controller**: Acts as the intermediary between the Model and View. Controllers like `FilmsController` and `HomeController` process user input and return responses.

## Project Structure

```
WatchList/
├── WatchList.sln
├── appsettings.json
├── Program.cs
├── Areas/
│   └── Identity/
├── Controllers/
│   ├── FilmListController.cs
│   ├── FilmsController.cs
│   ├── HomeController.cs
├── Data/
│   ├── ApplicationDbContext.cs
│   ├── Film.cs
│   ├── FilmUser.cs
│   ├── User.cs
├── Migrations/
│   ├── 20241215160242_first.cs
│   ├── 20241215160242_first.Designer.cs
│   ├── 20241215162234_user.cs
├── Models/
├── Views/
├── wwwroot/
│   ├── css/
│   ├── js/
│   ├── lib/
```

## How to Run

1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```
2. Set up a SQL Server database and update the connection string in `appsettings.json`.
3. Apply migrations to the database:
   ```bash
   dotnet ef database update
   ```
4. Run the application:
   ```bash
   dotnet run
   ```
5. Open the application in your browser at `http://localhost:5000`.
