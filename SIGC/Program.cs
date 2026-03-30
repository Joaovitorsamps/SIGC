using Supabase;
using SIGC.Contracts;
using SIGC.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<Supabase.Client>(provider =>
{
    var config = builder.Configuration;
    var client = new Supabase.Client(
        config["Supabase:Url"],
        config["Supabase:Key"],
        new SupabaseOptions
        {
            AutoRefreshToken = true,
            AutoConnectRealtime = false 
        });

    client.InitializeAsync().GetAwaiter().GetResult();
    return client;
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
    CreatePacientesRequest request,
    Supabase.Client client) =>
{
    var paciente = new Pacientes
    {
        CPF_Paciente = request.CPF_Paciente,
        Nome = request.Nome,
        DDD = request.DDD,
        Telefone = request.Telefone,
        CEP = request.CEP,
        Rua = request.Rua,
    };

    var response = await client.From<Pacientes>().Insert(paciente);
    var novo = response.Models.First();
    return Results.Ok(novo.CPF_Paciente);
});

app.MapGet("/Pacientes/{id}", async (
    string id, Supabase.Client client) =>
{
    var response = await client
        .From<Pacientes>()
        .Where(n => n.CPF_Paciente == id)
        .Get();

    var paciente = response.Models.FirstOrDefault();
    if (paciente == null) return Results.NotFound();

    return Results.Ok(new PacientesResponse
    {
        CPF_Paciente = paciente.CPF_Paciente,
        Nome = paciente.Nome,
        DDD = paciente.DDD,
        Telefone = paciente.Telefone,
        CEP = paciente.CEP,
        Rua = paciente.Rua,
    });
});

app.Run();