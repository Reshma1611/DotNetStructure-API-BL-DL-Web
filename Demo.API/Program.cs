using Microsoft.EntityFrameworkCore; //UseSqlServer
using Demo.DAL.Models;
using AutoMapper;
using Demo.BAL;
using Demo.BAL.Repository;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region connection string

builder.Services.AddDbContext<ApplicationContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

#endregion

#region cors
builder.Services.AddCors(option => option.AddDefaultPolicy(builder => builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()));
#endregion
#region Configure Auto Mapper
builder.Services.AddAutoMapper(typeof(Program));
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperProfile());
});
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion
#region
builder.Services.AddScoped<IState, State>();

builder.Services.AddScoped<ICity, City2>();
builder.Services.AddScoped<ICity, City>();
builder.Services.AddScoped<IUserRegistration, UserRegistration>();
#endregion
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
#region
app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});
#endregion
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
#region
app.UseHttpsRedirection();
app.UseRouting();
#endregion
app.Run();
