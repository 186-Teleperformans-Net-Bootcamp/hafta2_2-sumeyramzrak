using Microsoft.AspNetCore.Mvc;

namespace Bootcamp.Odev2._2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            //using var conn = new SqlConnection("Server=localhost,12000;Database=HWSchool;User Id=sa;Password=1q2w3e4R!;");
            //conn.Open();
            return Ok();
        }
    }
}