using PlanningPoker.Shared.Dtos;

namespace PlanningPoker.Client.Services.Rooms;

public sealed class RoomService : IRoomService
{
    private readonly HttpClient _httpClient;

    public RoomService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IReadOnlyCollection<RoomDto>?> GetActiveRooms()
    {
        return await _httpClient.GetFromJsonAsync<List<RoomDto>>("api/Room/active");
    }
}