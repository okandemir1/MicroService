using Contact.Api.Infrastructure;
using Contact.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//9000 Portunda çalýþsýn uygulamam
builder.WebHost.UseUrls("http://*:9000");

builder.Services.AddScoped<IContactService, ContactService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Dinamik olarak port yönlendirmesini engelliyor
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
