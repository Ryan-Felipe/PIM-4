var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=/teste/pagina_teste2}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "Teste",
    pattern: "/teste/pagina_teste",defaults:new{controller="Pagina_Teste",action="Pagina_Teste2"});

app.MapControllerRoute(
    name: "Registro",
    pattern: "/teste/registro",defaults:new{controller="Registro",action="Registro2"});

app.Run();
