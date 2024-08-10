using Domain.Contracts;

namespace Domain.Entities;

public class TableColumn : 
    IHasId,
    IHasDateCreated,
    IHasDateUpdated,
    IHasUserCreated,
    IHasUserUpdated
{
    public Guid Id { get; set; }

    public string Title { get; set; } = string.Empty;
    public int Sequence { get; set; }
    public Guid BoardId { get; set; }
    
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public Guid UserCreated { get; set; }
    public Guid UserUpdated { get; set; }
}