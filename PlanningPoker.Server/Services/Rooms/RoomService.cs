using PlanningPoker.Server.Models;

namespace PlanningPoker.Server.Services.Rooms;

public sealed class RoomService : IRoomService
{
    public Task<IEnumerable<Room>> GetActiveRooms()
    {
        IEnumerable<Room> list = new List<Room>
        {
            new(Guid.NewGuid(),
                "Room 1",
                new User(Guid.NewGuid(), "User 1")),
            new(Guid.NewGuid(),
                "Room 2",
                new User(Guid.NewGuid(), "User 2")),
            new(Guid.NewGuid(),
                "Room 3",
                new User(Guid.NewGuid(), "User 3")),
            new(Guid.NewGuid(),
                "Room 4",
                new User(Guid.NewGuid(), "User 4"))
        };

        return Task.FromResult(list);
    }
}