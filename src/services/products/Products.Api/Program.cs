using GraphQL.Server;
using Products.Api;
using Products.Api.GQL.Mutations;
using Products.Api.GQL.Queries;
using Products.Api.GQL;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceRegistery();
builder.AddInfrastructureServices();
builder.AddApplicationServices();

builder.Services.AddScoped<AppMutations>();
builder.Services.AddScoped<AppQueries>();
builder.Services.AddScoped<AppSchema>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddGraphQL().AddSystemTextJson();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseGraphQL<AppSchema>();
app.UseGraphQLGraphiQL("/ui/graphql");

app.UseAuthorization();

app.MapControllers();

app.Run();
