using Agenda.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddDbContext<AgendaContext>(opt => opt.UseInMemoryDatabase("Agenda"));

builder.Services.AddDbContext<AgendaContext>(opt => opt.UseSqlServer(@"Server=DESKTOP-C6VUHP3\LOCALDB#242382A1\SQLEXPRESS;Database=agenda;User_Id=root;Password=123456789"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
