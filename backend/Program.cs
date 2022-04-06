using Microsoft.OpenApi.Models;
using Parceria.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(swaggerGenOptions =>
{
    swaggerGenOptions.SwaggerDoc("v1", new OpenApiInfo { Title = "API Convite", Version = "v1" });
});

var app = builder.Build(); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/get-all-convites", async () => await ConviteRepository.GetConvitesAsync()).WithTags("Convites Endpoints");

app.MapPost("/create-convite", async (Convite conviteToCreate) =>
{
    var postCreated = await ConviteRepository.CreateConviteAsync(conviteToCreate);

    if (postCreated)
    {
        return Results.Ok("Create Sucessful");
    }
    else
    {
        return Results.BadRequest();
    }

}).WithTags("Convite Endpoints");

app.Run();
