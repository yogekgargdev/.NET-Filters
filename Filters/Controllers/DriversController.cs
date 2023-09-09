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
    [MyActionFilterAttribute]
    public IActionResult Get()
    {
        return Ok(MyDrivers);
    }

    [HttpPost]
    public IActionResult Post(string DriverName)
    {
        MyDrivers.Add(DriverName);
        return Ok(MyDrivers);
    }

       
    }
}
