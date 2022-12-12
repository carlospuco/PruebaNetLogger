using Microsoft.AspNetCore.Mvc;

namespace IloggerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Carlos", "Pepe", "Juan", "Karol"
    };

    private static readonly string[] Cedulas = new[]
    {
        "1726018094","1726014409", "1726568094", "1726018096"
    };

    private readonly ILogger<Clients> _logger;

    public ClientsController(ILogger<Clients> logger)
    {
        _logger = logger;
    }

    // public static string[] Base64Encode(string[] plainText)
    //     {
    //         var plainTextBytes = Encoding.UTF8.GetBytes(Cedulas);
    //         var cedulasEncrip = System.Convert.ToBase64String(plainTextBytes);
    //         return cedulasEncrip;
    //     }

    [HttpGet(Name = "GetClientes")]
    public IEnumerable<Clients> Get()
    {
        
        return Enumerable.Range(1, 5).Select(index => new Clients
        {
    
            
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            Cedulas = Cedulas[Random.Shared.Next(Cedulas.Length)],
        
            
        })
        .ToArray();
    }
}
