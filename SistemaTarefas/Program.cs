using Microsoft.EntityFrameworkCore;
using SistemaTarefas.Data.Contexto;
using SistemaTarefas.Data.Repositorio;
using SistemaTarefas.Data.Repositorio.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEntityFrameworkSqlServer().AddDbContext<SistemaTarefasContexto>(
                    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                );

builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();

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
