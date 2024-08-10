using Domain.Contracts;

namespace Domain.Entities;

public class TableWorkspace : 
    IHasId,
    IHasDateCreated,
    IHasDateUpdated,
    IHasUserCreated,
    IHasUserUpdated
{
    public Guid Id { get; set; }

    public Guid Owner { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public Guid UserCreated { get; set; }
    public Guid UserUpdated { get; set; }
}