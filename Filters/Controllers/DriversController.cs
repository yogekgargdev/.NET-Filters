using Filters.Configurations.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [MyActionFilterAttribute]
    public class DriversController : ControllerBase
    {
       private List<string> MyDrivers = new List<string>()
       {
           "Yogek Garg",
           "Abhinav Chandlda",
           "Ankit Jain",
           "Dishant Sood"
       };

    [HttpGet]
    [MyAsyncActionFilter]
    [MySecondActionFilter]
    [MyActionFilterAttribute]
    public IActionResult Get()
    {
        Console.WriteLine("Initalizing Get");
        return Ok(MyDrivers);
    }

    [HttpPost]
    [MyActionFilterAttribute]
    [MyAsyncActionFilter]
    [MySecondActionFilter]
    public IActionResult Post(string DriverName)
    {
        Console.WriteLine("Initalizing Post");
        MyDrivers.Add(DriverName);
        return Ok(MyDrivers);
    }

       
    }
}
