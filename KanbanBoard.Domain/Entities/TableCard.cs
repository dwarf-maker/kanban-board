using Domain.Contracts;

namespace Domain.Entities;

public class TableCard : 
    IHasId,
    IHasDateCreated,
    IHasDateUpdated,
    IHasUserCreated,
    IHasUserUpdated
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? Data { get; set; }

    public int Sequence { get; set; }

    public Guid ColumnId { get; set; }
    public Guid BoardId { get; set; }
    
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public Guid UserCreated { get; set; }
    public Guid UserUpdated { get; set; }
}