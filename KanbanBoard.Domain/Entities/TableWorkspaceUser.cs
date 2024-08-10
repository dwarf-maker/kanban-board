using Domain.Common;
using Domain.Contracts;

namespace Domain.Entities;

public class TableWorkspaceUser : 
    IHasId,
    IHasDateCreated,
    IHasDateUpdated,
    IHasUserCreated,
    IHasUserUpdated
{
    public Guid Id { get; set; }

    public Guid WorkspaceId { get; set; }
    public Guid UserId { get; set; }
    public RoleType RoleType { get; set; }
    
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public Guid UserCreated { get; set; }
    public Guid UserUpdated { get; set; }
}