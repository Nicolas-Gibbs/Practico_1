using Domain;
using IBusinessLogic;
using IDataAccess;

namespace BusinessLogic;

public class OrderService : IOrderService
{
    private IOrderRepository _repository;
    
    public OrderService(IOrderRepository OrderRepository)
    {
        _repository = OrderRepository;
    }
    
    public Order Add(Order order)
    {
        _repository.Add(order);
        return order;
    }
    public void Delete(Order order)
    {
        _repository.Delete(order);
    }
    public List<Order> GetAllOrders()
    {
        return _repository.GetAllOrders();
    }
}
