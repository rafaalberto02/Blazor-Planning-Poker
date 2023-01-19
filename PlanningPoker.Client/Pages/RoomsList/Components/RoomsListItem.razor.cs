using Microsoft.AspNetCore.Components;
using PlanningPoker.Shared.Dtos;

namespace PlanningPoker.Client.Pages.RoomsList.Components;

public partial class RoomsListItem
{
    [Parameter] public RoomDto? RoomObject { get; set; }
}