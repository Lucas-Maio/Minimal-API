var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Olá Pessoal");

app.MapPost("/login", (MinimalApi.DTOs.LoginDTO LoginDTO) => 
{
    if(LoginDTO.Email == "adm@teste.com" && LoginDTO.Senha == "123") 
        return Results.Ok("Login com sucesso");
    else 
        return Results.Unauthorized();
});


app.Run();

