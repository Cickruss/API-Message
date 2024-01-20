using api.message.Adapters.Inbound.Http;
using api.message.Service.Configuration;
ConfigurationService configurationService = new ConfigurationService();
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
configurationService.AddServices(builder);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.AddHttpRoute();
app.Run();
