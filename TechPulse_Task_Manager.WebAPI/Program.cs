using Microsoft.EntityFrameworkCore;
using TechPulse_Task_Manager.DATAACCESS.Interfaces;
using TechPulse_Task_Manager.DATAACCESS.Repositories;
using TechPulse_Task_Manager.DATAACCESS.ApplicationDbContext;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TaskDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);


builder.Services.AddScoped<IEmployeeService,EmployeeService>();
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddControllers();

// ✅ ADD SWAGGER
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // ✅ USE SWAGGER
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "TechPulse API v1");
        options.RoutePrefix = string.Empty; // Swagger opens at root
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
