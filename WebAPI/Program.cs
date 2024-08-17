using WebAPI.Infrastructure;
using WebAPI_Domain.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
DependancyBuilder.BuildDependency(builder.Services);
builder.Services.AddControllers();
builder.Services.AddSignalR();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200") // Allow the specific origin
                   .AllowAnyMethod()
                   .AllowAnyHeader()
                   .AllowCredentials(); // Allow credentials
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseRouting(); // Ensure routing is added before authorization and endpoints

app.UseAuthorization();

app.MapControllers();
app.MapHub<NotificationHub>("/notificationhub");


app.Run();

