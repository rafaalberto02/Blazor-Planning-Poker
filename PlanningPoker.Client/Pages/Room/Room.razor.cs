using Microsoft.AspNetCore.Components;

namespace PlanningPoker.Client.Pages.Room;

public partial class Room
{
    [Parameter]
    public Guid RoomId { get; set; }
}