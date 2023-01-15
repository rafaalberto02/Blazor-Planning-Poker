using PlanningPoker.Server.Models;

namespace PlanningPoker.Server.Services.Rooms;

public interface IRoomService
{
    Task<IEnumerable<Room>> GetActiveRooms();
}