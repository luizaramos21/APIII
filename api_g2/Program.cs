// Cria um objeto responsável por configurar a aplicação ASP.NET
var builder = WebApplication.CreateBuilder(args);

// Define o endereço e a porta em que a aplicação irá escutar requisições HTTP
builder.WebHost.UseUrls("http://localhost:8000");

// Constrói a aplicação web a partir das configurações definidas no builder
var app = builder.Build();

// Definição de rotas HTTP do tipo GET 
app.MapGet("/", () => "API funcionando com ASP.NET!");
app.MapGet("/saudacao", () => new {mensagem="Olá, mundo!" });

// Inicia o servidor web é iniciado e passa a aguardar requisições HTTP dos clientes
app.Run();

