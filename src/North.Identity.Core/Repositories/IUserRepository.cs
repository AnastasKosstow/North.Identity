using North.Identity.Core.Entities;

namespace North.Identity.Core.Repositories;

public interface IUserRepository
{
    Task<User> GetAsync(Guid id);
    Task<User> GetAsync(string email);
    Task AddAsync(User user);
}
