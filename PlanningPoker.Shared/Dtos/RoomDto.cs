namespace PlanningPoker.Shared.Dtos;

public sealed class RoomDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public UserDto OwnerUser { get; set; }
}