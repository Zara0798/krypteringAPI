namespace krypteringAPI.Controller;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Encrypt(string input)
    {
        // Reversa inputen string
        var encrypted = new string(input.Reverse().ToArray());
        return Ok(new { input, encrypted });
    }

    [HttpGet]
    public IActionResult Decrypt(string encrypted)
    {
        // Avkryptera genom att vända om stringen igen
        var decrypted = new string(encrypted.Reverse().ToArray());
        return Ok(new { encrypted, decrypted });
    }
}