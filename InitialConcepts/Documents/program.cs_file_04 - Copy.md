# The Main method in *Program.cs*

ASP.NET core application initially starts as a console application and the Main() method in Program.cs file is the entry point. 

- var builder = WebApplication.CreateBuilder(args);
    - Creates a WebApplicationBuilder object that is used to configure services and middleware for the application. The args parameter contains command-line arguments passed to the application.
- builder.Services.AddControllers();
    - Registers controller services in the dependency injection (DI) container. This enables the framework to instantiate and manage controllers.
- builder.Services.AddOpenApi();
    - Adds OpenAPI (Swagger) support to the application, which enables automatic API documentation and a web UI to interact with your API endpoints.
- var app = builder.Build();
    - Builds and creates the WebApplication instance based on all the services and configurations that were registered with the builder.
- if (app.Environment.IsDevelopment())
    - Conditionally checks if the application is running in the development environment (as opposed to production, staging, etc.).
- app.MapOpenApi();
    - Maps the OpenAPI endpoint, making it accessible only in development. This provides the Swagger UI and API documentation.
- app.UseHttpsRedirection();
    - Adds middleware that automatically redirects all HTTP requests to HTTPS for security.
- app.UseAuthorization();
    - Adds authorization middleware to enforce authorization policies on protected endpoints.
- app.MapControllers();
    - Maps all controller routes to the application's request pipeline so incoming requests are routed to the appropriate controller actions.
- app.Run();
    - Starts the web server and begins listening for incoming HTTP requests. This is a blocking call that keeps the application running.


| | | |
|-|-|-|
[![Home](../../Documents/Images/home_button.svg)](../../README.md) | [![Previous](../../Documents/Images/back_button.svg)](./creating_new_web_api_project_03.md) | [![Next](../../Documents/Images/next_button.svg)](./in_process_hosting_model_05.md) |
| | |
