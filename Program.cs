using Microsoft.EntityFrameworkCore;
using PicconnectAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// 1. Get the Aiven MySQL connection string
var aivenConnectionString =
    builder.Configuration.GetConnectionString("AivenConnection")
    ?? throw new InvalidOperationException(
        "AivenConnection connection string is missing.");

// 2. Register DbContext with Pomelo MySQL provider
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        aivenConnectionString,
        ServerVersion.AutoDetect(aivenConnectionString)));

// 5. Register Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.WithOrigins(
            "https://www.picconnect.org",
            "http://localhost:4200"
        )
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

// 9. Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAngular");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();
