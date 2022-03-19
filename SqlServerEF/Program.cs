using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SqlServerEF.Data;
using SqlServerEF.Interfaces;
using SqlServerEF.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SqlServerEFContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerEFContext")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//declare services
builder.Services.AddScoped<IBlogService, BlogService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
