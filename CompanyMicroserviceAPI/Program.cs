using CompanyMicroserviceAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel server to listen on all interfaces on port 5000
builder.WebHost.UseKestrel()
               .UseUrls("http://0.0.0.0:5001");


builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();


builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions => sqlOptions.EnableRetryOnFailure()); // Enable transient error resiliency
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure Swagger for development
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


// Remove HTTPS redirection if not using HTTPS
// app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();  // Start the application
