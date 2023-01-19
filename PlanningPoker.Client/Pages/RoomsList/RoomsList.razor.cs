using PlanningPoker.Client.Services.Rooms;
using PlanningPoker.Shared.Dtos;

namespace PlanningPoker.Client.Pages.RoomsList;

public partial class RoomsList
{
    private IReadOnlyCollection<RoomDto>? _roomCollection = null;
    private readonly IRoomService _roomService;

    public RoomsList(IRoomService roomService)
    {
        _roomService = roomService;
    }

    protected override async Task OnInitializedAsync()
    {
        _roomCollection = await _roomService.GetActiveRooms();
    }
}