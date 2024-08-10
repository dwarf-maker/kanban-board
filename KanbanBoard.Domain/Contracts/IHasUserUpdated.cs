using Domain.Entities;

namespace Domain.Contracts;

public interface IHasUserUpdated
{
    public Guid UserUpdated { get; set; }
}