using Domain.Contracts;

namespace Domain.Entities;

public class TableUser : 
    IHasId,
    IHasDateCreated,
    IHasDateUpdated,
    IHasUserCreated,
    IHasUserUpdated
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? SecondName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public Guid UserCreated { get; set; }
    public Guid UserUpdated { get; set; }
}