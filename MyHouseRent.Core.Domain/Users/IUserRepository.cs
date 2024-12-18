namespace HouseRent.Core.Domain.Users;

public interface IUserRepository
{
    Task<User?> GetUserById(int id);
    void Add(User user); 
}
