using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Cors;
using TodoApi.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<TodoDbContext>(opt => 
    opt.UseInMemoryDatabase("TodoList"));

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});


// builder.Services.Configure<HttpsRedirectionOptions>(options =>
// {
//     options.HttpsPort = 5000;
// });

builder.Services.AddControllers();

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

// app.UseHttpsRedirection();

app.UseRouting();
app.UseCors("AllowAll");
app.UseAuthorization();

app.MapControllers();

app.Run();
