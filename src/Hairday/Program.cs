using Hairday.Controllers;
using Hairday.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();


builder.Services.AddDbContext<AppDbContext>(options =>
options.UseMySql(
builder.Configuration.GetConnectionString("DefaultConnection"),
ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
)
);


builder.Services.AddSession();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); 
app.UseAuthorization();

app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//CÓDIGO PARA TESTE DO BANCO DE DADOS
/*
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();


    context.Clientes.Add(new Cliente
    {
        nome = "Fulano da Silvaa",
        email = "fulano22@email.com",
        senha = "123456",
        cidade = "São Paulos",
        telefone = "22999999999"
    });
    context.SaveChanges();
    Console.WriteLine("Cliente adicionado com sucesso!");
   
} */