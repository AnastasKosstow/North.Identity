using North.Identity.Core.Factory.Configuration;

namespace North.Identity.Core.Factory;

public interface IUserFactory
{
    IUserFactory CreateUser(Action<IUserConfiguration> configAction);
}
