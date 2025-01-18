
using CustomizingOpenApi;

using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi(x =>
{
    // Change the OpenAPI version..
    x.OpenApiVersion = OpenApiSpecVersion.OpenApi2_0;
    x.AddDocumentTransformer((document, context, cancellationToken) =>
    {
        document.Info.Contact = new OpenApiContact
        {
            Name = "Sander ten Brinke",
            Email = "s.tenbrinke2@gmail.com",
            Url = new Uri("https://stenbrinke.nl")
        };

        return Task.CompletedTask;
    });

    x.AddOperationTransformer<OpenApiInternalServerErrorOperationTransformer>();

    x.AddSchemaTransformer(new OpenApiDoubleToDecimalSchemaTransformer());
});

var app = builder.Build();

app.MapOpenApi();

app.MapWeatherEndpoints();

app.Run();


public class OpenApiInternalServerErrorOperationTransformer : IOpenApiOperationTransformer
{
    public Task TransformAsync(OpenApiOperation operation, OpenApiOperationTransformerContext context, CancellationToken cancellationToken)
    {
        operation.Responses.Add("500", new OpenApiResponse { Description = "Internal server error" });
        return Task.CompletedTask;
    }
}

public class OpenApiDoubleToDecimalSchemaTransformer : IOpenApiSchemaTransformer
{
    public Task TransformAsync(OpenApiSchema schema, OpenApiSchemaTransformerContext context, CancellationToken cancellationToken)
    {
        if (context.JsonTypeInfo.Type == typeof(decimal))
        {
            schema.Format = "decimal";
        }
        return Task.CompletedTask;
    }
}
