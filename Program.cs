var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

var app = builder.Build();

// Set the base path for the application
app.UsePathBase("/hello");

// Enable routing
app.UseRouting();

// Map the controllers
app.MapControllers();

app.MapGet("/", () => "Welcome to EnkrypteringAPI!");

app.Run();
