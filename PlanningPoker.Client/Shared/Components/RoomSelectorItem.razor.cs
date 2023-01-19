using Microsoft.AspNetCore.Components;
using PlanningPoker.Shared.Dtos;

namespace PlanningPoker.Client.Shared.Components;

public partial class RoomSelectorItem
{
    [Parameter]
    public RoomDto? RoomObject { get; set; }
    
    
}