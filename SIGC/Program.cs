using Supabase;
using Supabase.Interfaces;
using SIGC.Data;
using SIGC.Contracts;
using SIGC.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<Supabase.Client>(_ =>
    new Supabase.Client(
        builder.Configuration["Supabase:Url"],
        builder.Configuration["Supabase:Key"],
        new SupabaseOptions
        {
            AutoRefreshToken = true,
            AutoConnectRealtime = true
        }));

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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapPost("/Pacientes", async (
    CreatePacientesRequest Request,
    Supabase.Client client) =>
{
    var Paciente = new Pacientes
    {
        Nome = Request.Nome,
        DDD = Request.DDD,
        Telefone = Request.Telefone,
        Rua = Request.Rua,
    };

    var response = await client.From<Pacientes>().Insert(Paciente);

    var newPacientes = response.Models.First();

    return Results.Ok(newPacientes.CPF);
});

app.MapGet("/Pacientes/{id}", async (
    string id, Supabase.Client client) =>
{
    var response = await client
    .From<Pacientes>()
    .Where(n => n.CPF == id)
    .Get();

    var Paciente = response.Models.FirstOrDefault();
    if(Paciente == null) return Results.NotFound();

    if (Paciente == null)
    {
        return Results.NotFound();
    }

    var PacientesResponse = new PacientesResponse
    {
        CPF = Paciente.CPF,
        Nome = Paciente.Nome,
        DDD = Paciente.DDD,
        Telefone = Paciente.Telefone,
        CEP = Paciente.CEP,
        Rua = Paciente.Rua,
    };
    return Results.Ok(PacientesResponse);
});

app.Run();
