using EffectiveMobileTest;
using EffectiveMobileTest.AutoMapper;
using EffectiveMobileTest.Options;
using EffectiveMobileTest.Repository;
using EffectiveMobileTest.Request.FilteredOrders;
using EffectiveMobileTest.Request.Orders;
using EffectiveMobileTest.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(dbContext =>
{
    var connectionString = builder.Configuration["DbConnectionString"];
    dbContext.UseNpgsql(connectionString);
});
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IFilteredOrdersRepository, FilteredOrdersRepository>();
builder.Services.AddScoped<IFiltersAndOrdersRepository, FiltersAndOrdersRepository>();
builder.Services.AddScoped<FilterService>();
builder.Services.AddScoped<FileParserService>();
builder.Services.AddScoped<FilterByParamsValidator>();

builder.Host.UseSerilog((context, configuration) =>
{
    configuration.ReadFrom.Configuration(context.Configuration);
});

builder.Services.Configure<DeliverySetting>(builder.Configuration.GetSection("DeliverySetting"));
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddScoped<IValidator<CreateOrder>, CreateOrderValidator>();
builder.Services.AddMediatR(conf => conf.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddAutoMapper(conf =>
{
    conf.AddProfile<OrderProfile>();
});

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();
