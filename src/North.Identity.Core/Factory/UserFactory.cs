using North.Identity.Core.Entities;
using North.Identity.Core.Factory.Configuration;

namespace North.Identity.Core.Factory;

public class UserFactory : IUserFactory
{
    private DefaultUserConfigurationBuilder configuration;

    public IUserFactory CreateUser(Action<IUserConfiguration> configAction)
    {
        var configBuilder = new DefaultUserConfigurationBuilder();
        configAction?.Invoke(configBuilder);

        this.configuration = configBuilder;
        return this;
    }

    public User Build()
        =>
        new(configuration.Id,
            configuration.Credentials,
            configuration.Role,
            configuration.CreatedAt,
            configuration.Permissions);
}
