var builder = WebApplication.CreateBuilder(args);

// Configuration
var data = builder.Configuration.GetConnectionString("DefaultConnection"); // changed to GetConnectionString

// Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // fixed - actually add Swagger generator

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
