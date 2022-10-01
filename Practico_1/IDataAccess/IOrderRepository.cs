using Domain;

namespace IDataAccess;

public interface IOrderRepository
{
    public Order Add(Order order);
    public void Delete(Order order);
    public List<Order> GetAllOrders();
}
