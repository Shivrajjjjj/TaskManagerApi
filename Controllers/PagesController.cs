using Microsoft.AspNetCore.Mvc;

namespace TaskManagerApi.Controllers
{
    [Route("[controller]")]
    public class PagesController : Controller
    {
        private IActionResult ReturnHtmlFile(string filename)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", filename);
            return PhysicalFile(filePath, "text/html");
        }

        [HttpGet("index")]
        public IActionResult Index() => ReturnHtmlFile("index.html");

        [HttpGet("create")]
        public IActionResult Create() => ReturnHtmlFile("create.html");

        [HttpGet("tasks")]
        public IActionResult Tasks() => ReturnHtmlFile("tasks.html");

        [HttpGet("delete")]
        public IActionResult Delete() => ReturnHtmlFile("delete.html");

        [HttpGet("update")]
        public IActionResult Update() => ReturnHtmlFile("update.html");

        [HttpGet("dashboard")]
        public IActionResult Dashboard() => ReturnHtmlFile("dashboard.html");
    }
}
