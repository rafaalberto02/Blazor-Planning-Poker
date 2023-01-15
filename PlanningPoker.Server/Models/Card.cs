namespace PlanningPoker.Server.Models;

public sealed class Card
{
    public Card(User ownerUser, string? value)
    {
        OwnerUser = ownerUser;
        Value = value;
    }

    public User OwnerUser { get; set; }
    public string? Value { get; set; }
}