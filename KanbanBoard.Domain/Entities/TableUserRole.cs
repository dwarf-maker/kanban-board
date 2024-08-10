using Domain.Contracts;

namespace Domain.Entities;

public class TableUserRole : 
    IHasId
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
}