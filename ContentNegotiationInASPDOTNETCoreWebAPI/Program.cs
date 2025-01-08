using ContentNegotiationInASPDOTNETCoreWebAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers(options =>
//{
//    options.OutputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonOutputFormatter>();
//}).AddXmlSerializerFormatters();

builder.Services.AddControllers(options =>
{
    // Enable 406 Not Acceptable status code
    options.ReturnHttpNotAcceptable = true;
})
// Optionally, configure JSON options or other Formatter settings
.AddJsonOptions(options =>
{
    // Configure JSON serializer settings if needed
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<CustomNotAcceptableMiddleware>();

app.MapControllers();

app.Run();
