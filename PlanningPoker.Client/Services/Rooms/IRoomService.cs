using PlanningPoker.Shared.Dtos;

namespace PlanningPoker.Client.Services.Rooms;

public interface IRoomService
{
    Task<IReadOnlyCollection<RoomDto>?> GetActiveRooms();
}