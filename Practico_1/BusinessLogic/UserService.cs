using Domain;
using IBusinessLogic;
using IDataAccess;

namespace BusinessLogic;

public class UserService : IUserService
{
    private IUserRepository _repository;
    
    public UserService(IUserRepository UserRepository)
    {
        _repository = UserRepository;
    }
    
    public User Add(User user)
    {
        _repository.Add(user);
        return user;
    }
    public void Delete(User user)
    {
        _repository.Delete(user);
    }
    public List<User> GetAllUsers()
    {
        return _repository.GetAllUsers();
    }
}
