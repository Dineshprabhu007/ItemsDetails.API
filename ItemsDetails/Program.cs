using ItemsDetails.Models;
using ItemsDetails.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<ItemsImportDatabaseSettings>(builder.Configuration.GetSection(nameof(ItemsImportDatabaseSettings)));

builder.Services.AddSingleton<IItemsImportDatabaseSettings>
    (sp => sp.GetRequiredService<IOptions<ItemsImportDatabaseSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s => new MongoClient
(builder.Configuration.GetValue<string>("ItemsImportDatabaseSettings:ConnectionString")));

builder.Services.AddScoped<IItemsServices, ItemsServices>();

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
