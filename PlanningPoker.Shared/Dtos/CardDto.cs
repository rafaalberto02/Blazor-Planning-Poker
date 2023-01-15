namespace PlanningPoker.Shared.Dtos;

public sealed class CardDto
{
    public UserDto OwnerUser { get; set; }
    public string? Value { get; set; }
}