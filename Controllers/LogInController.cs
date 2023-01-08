using Microsoft.AspNetCore.Mvc;
using VinylStoreWebApp.Models;
using VinylStoreWebApp.Models;

namespace VinylStoreWebApp.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel dogo = new DogViewModel() { Name = "Fido", Age = 3};
            return View(dogo);
        }
        public string SignUp()
        {
            return "Who's there?";
        }
        
    }
}
