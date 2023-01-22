using North.Identity.Core.Abstractions;
using North.Identity.Core.ValueObjects;

namespace North.Identity.Core.Entities;

public class User : IAggregateRoot
{
    public Guid Id { get; private set; }
    public Credentials Credentials { get; private set; }
    public IdentityRole Role { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public IEnumerable<string> Permissions { get; private set; }

    internal User(
        Guid id,
        Credentials credentials,
        IdentityRole role, 
        DateTime createdAt,
        IEnumerable<string> permissions = null)
    {
        Id = id;
        Credentials = credentials;
        Role = role;
        CreatedAt = createdAt;
        Permissions = permissions;
    }
}

