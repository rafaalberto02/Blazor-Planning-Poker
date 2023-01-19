using Microsoft.AspNetCore.Components;

namespace PlanningPoker.Client.Pages;

public partial class Index
{
    [Inject] public NavigationManager NavigationManager { get; set; } = default!;

    protected override void OnInitialized()
    {
        NavigationManager.NavigateTo("/RoomsList");
    }
}