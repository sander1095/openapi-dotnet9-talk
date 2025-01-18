using System.Text.Json.Serialization;

using AheadOfTime;

using ApiModels;

using Microsoft.AspNetCore.Routing.Constraints;

using Scalar.AspNetCore;

var builder = WebApplication.CreateSlimBuilder(args);

// In AOT projects, Reflection has quite limited support:
_ = System.Reflection.Assembly.GetExecutingAssembly().GetTypes();

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

// Necessary for Scalar when using SlimBuilder for AOT: https://github.com/scalar/scalar/issues/4490
builder.Services.Configure<RouteOptions>(options => options.SetParameterPolicy<RegexInlineRouteConstraint>("regex"));

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference();
app.MapTalkEndpoints();

app.Run();

[JsonSerializable(typeof(TalkModel))]
[JsonSerializable(typeof(CreateTalkModel))]
[JsonSerializable(typeof(List<TalkModel>))]
[JsonSerializable(typeof(HttpValidationProblemDetails))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{

}
