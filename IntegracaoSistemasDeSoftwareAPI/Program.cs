using Admin.Domain.Handlers;
using Admin.Domain.Handlers.Contracts;
using Admin.Domain.Repositories;
using Admin.Infra.Queries;
using Admin.Infra.Repository;

var builder = WebApplication.CreateBuilder(args);
InjectDependencies(builder.Services);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

void InjectDependencies(IServiceCollection services)
{
    services.AddScoped<IProductHandler, ProductHandler>();
    services.AddScoped<IProductRepository, ProductRepository>();
    services.AddScoped<ProductQueries, ProductQueries>();
}