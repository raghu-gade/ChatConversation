using Conversation.API.Extensions;
using Conversation.RequestHandler.Account;
using Conversation.RequestHandler.CallHandler;
using Conversation.RequestHandler.ChatHandler;
using Conversation.RequestHandler.MessageHandler;
using Conversation.RequestHandler.ParticipantHandler;
using Conversation.RequestHandler.UserHandler;
using Conversation.Services.Accounts;
using Conversation.Services.CallService;
using Conversation.Services.Chat;
using Conversation.Services.MessageService;
using Conversation.Services.ParticipantService;
using Conversation.Services.UserService;
using ConversationAPI.DataAccess.EntityPlatform;
using RequestHandler;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("*.*",
                                              "http://localhost:4200", "https://localhost:4200").AllowAnyHeader()
                          .AllowAnyMethod();
                      });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks()
                   .AddSqlServer(
                   builder.Configuration.GetConnectionString("DBConnection"),
                   name: "DB-Connection",
                   tags: new string[] { "DB Connection" });
builder.Services.RegisterDatabaseProvider(builder.Configuration);
builder.Services.RegisterLocalServices();
builder.Services.AddScoped<IHttpHandler, HttpHandler>();
builder.Services.AddScoped<IEntityHandler, EntityHandler>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IMessageHandler, MessageHandler>();
builder.Services.AddScoped<ICallService, CallService>();
builder.Services.AddScoped<ICallHandler, CallHandler>();
builder.Services.AddScoped<IAccountService,Accountservice>();
builder.Services.AddScoped<IAccountsHandler,AccountsHandler>();
builder.Services.AddScoped<IChatService, ChatService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserHandler, UserHandler>();
builder.Services.AddScoped<IChatHandler, ChatHandler>();
builder.Services.AddScoped<IParticipantService, ParticipantService>();
builder.Services.AddScoped<IParticipantHandler, ParticipantHandler>();
builder.Services.AddSingleton<HttpClient>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(MyAllowSpecificOrigins);
//app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
