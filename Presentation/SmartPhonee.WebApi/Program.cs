using SmartPhonee.Application.Features.Mediator.Handlers.ProductHandlers;
using SmartPhonee.Application.Interfaces;
using SmartPhonee.Application.Interfaces.ProductInterface;
using SmartPhonee.Application.Services;
using SmartPhonee.Persistance.Context;
using SmartPhonee.Persistance.Repositories;
using SmartPhonee.Persistance.Repositories.ProductRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<SmartPhoneeContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));



builder.Services.AddAplicationService(builder.Configuration);







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
