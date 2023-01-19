using Microsoft.AspNetCore.Components;
using PlanningPoker.Shared.Dtos;

namespace PlanningPoker.Client.Pages.RoomsList.Components;

public partial class RoomsListItem
{
    [Inject] public NavigationManager NavigationManager { get; set; } = default!;
    [Parameter] public RoomDto? RoomObject { get; set; }

    private void GotoRoomPage()
    {
        if (RoomObject is not null)
            NavigationManager.NavigateTo($"/Room/{RoomObject.Id}");
    }
}