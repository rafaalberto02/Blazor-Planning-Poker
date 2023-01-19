using Microsoft.AspNetCore.Components;
using PlanningPoker.Client.Services.Rooms;
using PlanningPoker.Shared.Dtos;

namespace PlanningPoker.Client.Pages.RoomsList;

public partial class RoomsList
{
    private IReadOnlyCollection<RoomDto>? _roomCollection;

    [Inject] protected IRoomService RoomService { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        _roomCollection = await RoomService.GetActiveRooms();
    }
}