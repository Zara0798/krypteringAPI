namespace krypteringAPI.Controller;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Encrypt(string input)
    {
        // Validate input
        if (string.IsNullOrEmpty(input))
        {
            return BadRequest(new
            {
                Error = "Input text cannot be null or empty."
            });
        }

        // Reverse the input string
        var encrypted = new string(input.Reverse().ToArray());
        return Ok(new
        {
            Input = input,
            Encrypted = encrypted
        });
    }

    [HttpGet]
    public IActionResult Decrypt(string encrypted)
    {
        // Validate input
        if (string.IsNullOrEmpty(encrypted))
        {
            return BadRequest(new
            {
                Error = "Encrypted text cannot be null or empty."
            });
        }

        // Reverse the encrypted string to decrypt
        var decrypted = new string(encrypted.Reverse().ToArray());
        return Ok(new
        {
            Encrypted = encrypted,
            Decrypted = decrypted
        });
    }
}
