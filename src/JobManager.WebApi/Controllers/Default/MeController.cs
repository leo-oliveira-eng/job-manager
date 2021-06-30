using Microsoft.AspNetCore.Mvc;

namespace JobManager.WebApi.Controllers.Default
{
    [ApiController, Route("api/[controller]")]
    public class MeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new { name = "Job.Manager", version = "1.0.0" });
    }
}
