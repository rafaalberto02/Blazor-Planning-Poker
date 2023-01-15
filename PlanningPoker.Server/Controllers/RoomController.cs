using Microsoft.AspNetCore.Mvc;
using PlanningPoker.Server.Services.Rooms;

namespace PlanningPoker.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class RoomController : Controller
{
    private readonly IRoomService _roomService;

    public RoomController(IRoomService roomService)
    {
        _roomService = roomService;
    }

    [HttpGet("active")]
    public async Task<IActionResult> GetActiveRooms()
        => Ok(await _roomService.GetActiveRooms());
}