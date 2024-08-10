using Domain.Entities;

namespace Domain.Contracts;

public interface IHasUserCreated
{
    public Guid UserCreated { get; set; }
}