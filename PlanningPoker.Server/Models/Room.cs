namespace PlanningPoker.Server.Models;

public sealed class Room
{
    public Room(Guid id, string name, User ownerUser)
    {
        Id = id;
        Name = name;
        OwnerUser = ownerUser;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public User OwnerUser { get; set; }
}