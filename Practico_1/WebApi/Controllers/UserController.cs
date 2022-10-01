using Domain;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/Users")]
public class UserController: ControllerBase {
    
    private IUserService _UserService;
    
    public UserController(IUserService UserService){
        _UserService = UserService;
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        List<User> Users = _UserService.GetAllUsers();
        return Ok (Users);
    }
    
    [HttpPost]
    public IActionResult Add([FromBody] User user)
    {
        User UserCreated = _UserService.Add(user);
        return Created("", UserCreated);
    }
}