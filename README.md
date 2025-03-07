# BooksAPI Project

## Overview
BooksAPI is a .NET 8 Web API application that allows users to perform CRUD operations on book data. The application uses Entity Framework Core with SQLite as the database.

## Project Structure
```
BooksAPI
├── Controllers
│   └── BooksController.cs
├── Models
│   └── Book.cs
├── Data
│   ├── BookDbContext.cs
│   └── Repository
│       ├── IBookRepository.cs
│       └── BookRepository.cs
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
├── BooksAPI.csproj
└── README.md
```

## Getting Started

### Prerequisites
- .NET 8 SDK
- SQLite

### Installation
1. Clone the repository:
   ```
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```
   cd BooksAPI
   ```

### Configuration
- Update the `appsettings.json` file with your SQLite connection string.

### Running the Application
1. Restore the dependencies:
   ```
   dotnet restore
   ```
2. Run the application:
   ```
   dotnet run
   ```

### API Endpoints
- `GET /api/books` - Retrieve all books
- `GET /api/books/{id}` - Retrieve a book by ID
- `POST /api/books` - Create a new book
- `PUT /api/books/{id}` - Update an existing book
- `DELETE /api/books/{id}` - Delete a book

## Contributing
Feel free to submit issues or pull requests for improvements or bug fixes.

## License
This project is licensed under the MIT License.