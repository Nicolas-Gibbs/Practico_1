using Domain;

namespace IBusinessLogic;

public interface IUserService
{
    public User Add(User user);
    public void Delete(User user);
    public List<User> GetAllUsers();
}