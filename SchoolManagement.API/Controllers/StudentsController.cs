using Microsoft.AspNetCore.Mvc;

namespace SchoolManagement.API.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
