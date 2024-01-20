using api.message.Adapters.Inbound.Http;
using api.message.Service.Configuration;
var builder = WebApplication.CreateBuilder(args);
ConfigurationService configurationService =
    new ConfigurationService(builder.Services, builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
configurationService.AddServices();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.AddHttpRoute();
app.Run();
