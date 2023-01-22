namespace North.Identity.Core.Exceptions;

public class InvalidRoleException : DomainException
{
    public override string Code { get; } = "invalid_role";

    public string Role { get; }

    public InvalidRoleException(string role) : base($"Invalid role: {role}")
    {
        Role = role;
    }
}
