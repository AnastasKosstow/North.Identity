namespace North.Identity.Core.ValueObjects;

public record IdentityRole
{
    public const string User = "user";
    public const string Admin = "admin";

    public string Role { get; private set; }

    internal IdentityRole(string role)
    {
        Role = role;
    }

    public static bool IsValid(string role)
    {
        if (string.IsNullOrWhiteSpace(role))
        {
            return false;
        }

        role = role.ToLowerInvariant();

        return role == User || role == Admin;
    }
}
