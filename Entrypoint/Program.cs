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
using Services.CategoryService.PeopleCategoryService;
using Services.CategoryService.TaxCategoryService;
using Services.CommandHandler;
using Services.GameStateService;
using Services.ManagerService.ActionConnectionManagerService;
using Services.ManagerService.CategoryManagerService.PeopleCategoryManager;
using Services.ManagerService.WeightConnectionManagerService;
using Services.ManagerService.WeightValidationManagerService;
using Services.ViewHandler.ActionViewer;
using Services.ViewHandler.ConnectionViewer;
using Services.ViewHandler.GameStateViewer;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICommandHandler<CompleteActionCmd>, ActionServiceHandler>();
builder.Services.AddScoped<ICommandHandler<ChangeConnectionWeight>, ChangeConnectionWeightHandler>();
builder.Services.AddScoped<ICommandHandler<SimulateGameDay>, SimulateGameDayHandler>();

builder.Services.AddSingleton<IExternalAction, ChangeTaxBracketAction>();
builder.Services.AddSingleton<IGameStateService, StateService>();
builder.Services.AddSingleton<IActionRunnerService, ChainActionRunnerService>();
builder.Services.AddSingleton<IJsonFileAdapter, JsonAdapter>();
builder.Services.AddSingleton<IActionConnectionService, ConnectionService>();

builder.Services.AddSingleton<IExternalActionViewer, ExternalActionViewer>();
builder.Services.AddSingleton<IConnectionViewer, ConnectionWeightViewer>();
builder.Services.AddSingleton<IGameStateViewer, StateViewer>();

builder.Services.AddSingleton<ITaxCategoryService, TaxService>();
builder.Services.AddSingleton<IPeopleCategoryService, PeopleService>();

builder.Services.AddSingleton<IPeopleCategoryManager, PeopleManager>();
builder.Services.AddSingleton<IConnectionManagerService, ConnectionManagerService>();
builder.Services.AddSingleton<IWeightConnectionManagerService, WeightConnectionManager>();
builder.Services.AddSingleton<IWeightValidationManagerService, WeightValidationManager>();

builder.Services.AddSingleton<IActionHandler, ChangeTaxBracketHandler>();
builder.Services.AddSingleton<IActionHandler, ChangeEducationBudgetHandler>();
builder.Services.AddSingleton<IActionHandler, ChangeGovernmentBudgetHandler>();

builder.Services.AddSingleton<IArgumentFactory<ChangeEducationBudgetArgument>, ChangeEducationBudgetArgumentFactory>();
builder.Services.AddSingleton<IArgumentFactory<ChangeTaxBracketArgument>, ChangeTaxBracketArgumentFactory>();
builder.Services.AddSingleton<IArgumentFactory<ChangeGovernmentBudgetArgument>, ChangeGovernmentBudgetFactory>();



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
