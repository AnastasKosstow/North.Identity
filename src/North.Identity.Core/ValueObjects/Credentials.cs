namespace North.Identity.Core.ValueObjects;

public record Credentials
{
    public string Email { get; private set; }
    public string Password { get; private set; }

    internal Credentials(string email, string password)
    {
        (Email, Password) = (email, password);
    }
}
