using Domain;

namespace IBusinessLogic;

public interface IOrderService
{
    public Order Add(Order order);
    public void Delete(Order order);
    public List<Order> GetAllOrders();
}