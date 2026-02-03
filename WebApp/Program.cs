var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", BackEndpoints.ShowHTMLforIndex);

app.Run("http://localhost:2026");

static class BackEndpoints
{
        public static async Task<IResult> ShowHTMLforIndex()
    {
        var html = await File.ReadAllTextAsync("index.html");
        return Results.Content(html, "text/html");
    }
}