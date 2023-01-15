using PlanningPoker.Server.Services.Rooms;

namespace PlanningPoker.Server.DI;

public static class ServicesInjector
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IRoomService, RoomService>();
    }
}