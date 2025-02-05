var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

// Map the controllers
app.MapControllers();

app.Run();
