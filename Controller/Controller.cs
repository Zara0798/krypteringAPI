namespace krypteringAPI.Controller;
using Microsoft.AspNetCore.Mvc;

[Route("")]
[ApiController]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello from the API!");
    }
}
