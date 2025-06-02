# BTNX Profile Application

This is a .NET solution consisting of a Blazor Web Application frontend and a .NET Web API backend for managing user profiles.

## Project Structure

The solution contains two main projects:

### BTNXProfileApp
A Blazor Web Application that serves as the frontend of the application. It includes:
- Blazor components and pages
- Models for data representation
- Services for API communication
- Layout components for UI structure

### BTNXProfileApi
A .NET Web API project that serves as the backend. It includes:
- API endpoints for profile management
- Data models
- Configuration settings

## Prerequisites

- .NET 8.0 SDK or later
- Visual Studio 2022 or Visual Studio Code
- Git

## Getting Started

1. Clone the repository:
```bash
git clone [repository-url]
```

2. Open the solution:
```bash
cd BTNX-INTERVIEW
dotnet restore
```

3. Run the application:
```bash
# Run the API project
cd BTNXProfileApi
dotnet run

# In a separate terminal, run the Blazor app
cd BTNXProfileApp
dotnet run
```

## Development

- The API will be available at `https://localhost:7001` (or similar port)
- The Blazor application will be available at `https://localhost:5001` (or similar port)

## Project Features

- User profile management
- Modern web interface using Blazor
- RESTful API architecture
- Clean separation of concerns between frontend and backend

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details. 