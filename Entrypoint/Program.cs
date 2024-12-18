using Domain.Commands;
using Domain.Models.Actions.ExternalActions;
using Services.CommandHandler;
using Services.ViewHandler.ActionViewer;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICommandHandler<CompleteActionCmd>, ActionServiceHandler>();
builder.Services.AddSingleton<IExternalActionViewer, ExternalActionViewer>();
builder.Services.AddSingleton<IExternalAction, ChangeTaxBracketAction>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
