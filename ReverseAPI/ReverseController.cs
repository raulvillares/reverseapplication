using Microsoft.AspNetCore.Mvc;

namespace ReverseApp;

[ApiController]
[Route("[controller]")]
public class ReverseController : Controller
{
    public string Get(string text)
    {
        var reverser = new Reverser();
        return reverser.Reverse(text);
    }
}