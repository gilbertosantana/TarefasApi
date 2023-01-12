using TarefasApi.Endpoints;
using TarefasApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddPersistence();

var app = builder.Build();

app.MapTarefasEndPoints();

app.Run();
