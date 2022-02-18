using Microsoft.AspNetCore.Mvc;


namespace AnimesFinalBoss
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

    }
}
