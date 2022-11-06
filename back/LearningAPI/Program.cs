using DAL.Data;
using LearningAPI.Hubs;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using DAL.StateMachines;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();

builder.Services.Configure<IISServerOptions>(options =>
{
    options.MaxRequestBodySize = int.MaxValue;
});

/*builder.Services.Configure<FormOptions>(x =>
{
    x.ValueLengthLimit = int.MaxValue;
    x.MultipartBodyLengthLimit = int.MaxValue; // if don't set default value is: 128 MB
    x.MultipartHeadersLengthLimit = int.MaxValue;
});
*/
builder.Services.AddCors(options =>
{
    options.AddPolicy("ClientPermission", policy =>
    {
        policy.AllowAnyHeader()
            .AllowAnyMethod()
            .WithOrigins("http://localhost:3000")
            .AllowCredentials();
    });
});

var sqlConnectionString = builder.Configuration.GetConnectionString("Local");
builder.Services.AddDbContext<LearningContext>(options =>
                options.UseSqlServer(
                    sqlConnectionString
                )
            );

builder.Services.AddMassTransit(x =>
{
    x.UsingInMemory();
    x.AddSagaStateMachine<OfferStateMachine, OfferState>().InMemoryRepository();
    /*.EntityFrameworkRepository(r =>
    {
        r.ConcurrencyMode = ConcurrencyMode.Pessimistic;

        r.AddDbContext<DbContext, OfferStateContext>((provider, builder) =>
        {
            builder.UseSqlServer(sqlConnectionString, m =>
            {
                m.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name);
                m.MigrationsHistoryTable($"__{nameof(OfferStateContext)}");
            });
        });
    });*/
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("ClientPermission");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapHub<NotificationHub>("/notifications");
app.Run();
