using PlanningPoker.Client.Services.Rooms;

namespace PlanningPoker.Client.DI;

public static class ServicesInjector
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        var baseAddress = builder.Configuration["PlanningPokerServerUrl"];

        var services = builder.Services;
        services.AddHttpClient<IRoomService, RoomService>(client => client.BaseAddress = new Uri(baseAddress!));
    }
}