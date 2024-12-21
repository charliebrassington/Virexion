using Adapters.JsonFileAdapter;
using Domain.Commands;
using Domain.ModelFactories.ArgumentFactories;
using Domain.Models.Actions.ExternalActionArguments;
using Domain.Models.Actions.ExternalActions;
using Domain.Models.Actions.InternalActionArguments;
using Services.ActionConnectionService;
using Services.ActionHandler;
using Services.ActionHandler.Handlers;
using Services.ActionRunnerService;
using Services.CategoryService.TaxCategoryService;
using Services.CommandHandler;
using Services.GameStateService;
using Services.ManagerService.ActionConnectionManagerService;
using Services.ViewHandler.ActionViewer;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICommandHandler<CompleteActionCmd>, ActionServiceHandler>();
builder.Services.AddSingleton<IExternalActionViewer, ExternalActionViewer>();
builder.Services.AddSingleton<IExternalAction, ChangeTaxBracketAction>();
builder.Services.AddSingleton<IGameStateService, StateService>();
builder.Services.AddSingleton<ITaxCategoryService, TaxService>();
builder.Services.AddSingleton<IActionRunnerService, ChainActionRunnerService>();
builder.Services.AddSingleton<IJsonFileAdapter, JsonAdapter>();
builder.Services.AddSingleton<IConnectionManagerService, ConnectionManagerService>();
builder.Services.AddSingleton<IActionConnectionService, ConnectionService>();

builder.Services.AddSingleton<IActionHandler, ChangeTaxBracketHandler>();
builder.Services.AddSingleton<IActionHandler, ChangeEducationBudgetHandler>();

builder.Services.AddSingleton<IArgumentFactory<ChangeEducationBudgetArgument>, ChangeEducationBudgetArgumentFactory>();
builder.Services.AddSingleton<IArgumentFactory<ChangeTaxBracketArgument>, ChangeTaxBracketArgumentFactory>();



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
