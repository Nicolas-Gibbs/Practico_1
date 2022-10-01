using Domain;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/orders")]
public class OrderController: ControllerBase {
    
    private IOrderService _orderService;
    
    public OrderController(IOrderService orderService){
        _orderService = orderService;
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        List<Order> orders = _orderService.GetAllOrders();
        return Ok (orders);
    }
    
    [HttpPost]
    public IActionResult Add([FromBody] Order order)
    {
        Order orderCreated = _orderService.Add(order);
        return Created("", orderCreated);
    }
}