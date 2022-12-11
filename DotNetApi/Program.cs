using DotNetApi.Services;
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddScoped<IStudentService, StudentService>();
}

var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();