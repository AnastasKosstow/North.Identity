namespace North.Identity.Core.Factory.Configuration;

public interface IUserConfiguration
{
    IUserConfiguration WithId(Guid id);
    IUserConfiguration WithCredentials(string email, string password);
    IUserConfiguration WithRole(string role);
    IUserConfiguration UserIsCreatedAt(DateTime createdAt);
    IUserConfiguration WithPermissions(IEnumerable<string> permissions);
}
