using CRUDTWO.Data;
using Microsoft.AspNetCore.Mvc;

namespace CRUDTWO.Controllers
{
    public class CategoryController : Controller
    {

      
        public IActionResult Index()
        {

           
            return View();
        }
        public IActionResult Create()
        {
            return View();

        }
    }
}
