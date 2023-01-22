using North.Identity.Core.Exceptions;
using North.Identity.Core.ValueObjects;

namespace North.Identity.Core.Factory.Configuration;

internal class DefaultUserConfigurationBuilder : IUserConfiguration
{
    public Guid Id { get; private set; }
    public Credentials Credentials { get; private set; }
    public IdentityRole Role { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public IEnumerable<string> Permissions { get; private set; } = Enumerable.Empty<string>();

    public IUserConfiguration WithId(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new InvalidAggregateIdException();
        }

        Id = id;
        return this;
    }

    public IUserConfiguration WithCredentials(string email, string password)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new InvalidEmailException(email);
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            throw new InvalidPasswordException();
        }

        var credentials = new Credentials(email.ToLowerInvariant(), password);
        Credentials = credentials;

        return this;
    }

    public IUserConfiguration WithRole(string role)
    {
        if (string.IsNullOrWhiteSpace(role) || !IdentityRole.IsValid(role))
        {
            throw new InvalidRoleException(role);
        }

        var identityRole = new IdentityRole(role.ToLowerInvariant());
        Role = identityRole;

        return this;
    }

    public IUserConfiguration UserIsCreatedAt(DateTime createdAt)
    {
        CreatedAt = createdAt;
        return this;
    }

    public IUserConfiguration WithPermissions(IEnumerable<string> permissions)
    {
        if (permissions is {} && permissions.Any())
        {
            Permissions = permissions;
        }
        return this;
    }
}
