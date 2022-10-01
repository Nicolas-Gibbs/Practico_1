using Domain;
using IDataAccess;

namespace DataAccess;

public class OrderRepository : IOrderRepository
{
    private ContextDb _contextDb;
    
    public OrderRepository(ContextDb contextDb)
    {
        _contextDb = contextDb;
    }
    
    public Order Add(Order order)
    {
        _contextDb.Orders.Add(order);
        _contextDb.SaveChanges();
        return order;
    }

    public void Delete(Order order)
    {
        _contextDb.Orders.Remove(order);
        _contextDb.SaveChanges();
    }

    public List<Order> GetAllOrders()
    {
        return _contextDb.Orders.ToList();
    }
    
}
