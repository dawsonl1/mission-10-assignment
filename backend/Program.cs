using Microsoft.EntityFrameworkCore;
using backend.data;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddDbContext<BowlerDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("Default"));
});

var app = builder.Build();


// app.UseHttpsRedirection();

app.MapControllers();


app.Run();