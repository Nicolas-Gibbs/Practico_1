using Domain;
using IDataAccess;

namespace DataAccess;

public class UserRepository : IUserRepository
{
    private ContextDb _contextDb;
    
    public UserRepository(ContextDb contextDb)
    {
        _contextDb = contextDb;
    }
    
    public User Add(User user)
    {
        _contextDb.Users.Add(user);
        _contextDb.SaveChanges();
        return user;
    }

    public void Delete(User user)
    {
        _contextDb.Users.Remove(user);
        _contextDb.SaveChanges();
    }

    public List<User> GetAllUsers()
    {
        return _contextDb.Users.ToList();
    }
    
}
