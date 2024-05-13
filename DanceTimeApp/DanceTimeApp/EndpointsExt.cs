namespace DanceTimeApp;

public static class EndpointsExt
{
    public static void MapMainEnd(this WebApplication app)
    {
        app.MapGet("/main", async context =>
        {
            await context.Response.SendFileAsync("www/main.html");
        });
    }
    public static void MapSignInEnd(this WebApplication app)
    {
        app.MapGet("/signin", async context =>
        {
            await context.Response.SendFileAsync("www/signin.html");
        });
    }
    public static void MapRegistrationEnd(this WebApplication app)
    {
        app.MapGet("/regist", async context =>
        {
            await context.Response.SendFileAsync("www/registration.html");
        });
    }
    public static void MapRecordsEnd(this WebApplication app)
    {
        app.MapGet("/records", async context =>
        {
            await context.Response.SendFileAsync("www/records.html");
        });
    }
    public static void MapScheduleEnd(this WebApplication app)
    {
        app.MapGet("/schedule", async context =>
        {
            await context.Response.SendFileAsync("www/schedule.html");
        });
    }
    public static void MapTrainerEnd(this WebApplication app)
    {
        app.MapGet("/trainer", async context =>
        {
            await context.Response.SendFileAsync("www/trainers.html");
        });
    }
    public static void MapInfoTrainerEnd(this WebApplication app)
    {
        app.MapGet("/infoTrainer", async context =>
        {
            await context.Response.SendFileAsync("www/infoTrainer.html");
        });
    }
}