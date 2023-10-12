using Microsoft.AspNetCore.Mvc;

namespace soufianeBlog.Controllers
{
    public class BlogController : ControllerBase
    {
        [HttpGet("Blogs")]
        public ValueTask<IActionResult> GetBlogs()
        {
            return new ValueTask<IActionResult>(Ok("Blogs"));
        }
    }
}
