using Microsoft.AspNetCore.Mvc;

namespace TextAPI.Controllers
{
    [Route("api/controller")]
    [ApiController]

    public class TodosController : Controller
    {
        [HttpGet]
        public IActionResult GetTodos()
        {
            return Ok();
        }
    }
}
