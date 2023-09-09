using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
