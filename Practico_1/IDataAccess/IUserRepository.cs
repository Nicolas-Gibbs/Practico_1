using Domain;

namespace IDataAccess;

public interface IUserRepository
{
    public User Add(User user);
    public void Delete(User user);
    public List<User> GetAllUsers();
}
