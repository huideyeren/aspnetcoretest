var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => $"This platform is \"{Environment.OSVersion.VersionString}\" ");

app.Run();
