namespace krypteringAPI.Controller;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Encrypt(string input)
    {
        // Reverse the input string
        var encrypted = new string(input.Reverse().ToArray());
        return Ok(new { input, encrypted });
    }
}
