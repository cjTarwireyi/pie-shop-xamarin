using PieShopMobile.API.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<PieRepository>();
builder.Services.AddScoped<ShoppingCartRepository>();
var app = builder.Build();

app.UseHttpsRedirection();
app.Run();
