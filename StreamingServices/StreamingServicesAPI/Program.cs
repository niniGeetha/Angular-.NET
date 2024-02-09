using Microsoft.EntityFrameworkCore;
using StreamingServicesAPI.Data;
using StreamingServicesAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<StreamingServiceDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("StreamingServicesConnectionString")));
builder.Services.AddScoped<IGenreRepository, GenreRepository>();
builder.Services.AddScoped<IDemographicGroupRepository,DemographicGroupRepository>();
builder.Services.AddScoped<IStreamingServiceRepository,StreamingServiceRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors(builder => builder.AllowAnyHeader().WithOrigins("http://localhost:4200"));
app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();



app.MapControllers();

app.Run();
