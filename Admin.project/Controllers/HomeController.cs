using Admin.project.Contexts;
using Admin.project.Models;
using Admin.project.Views.VM;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Admin.project.Controllers
{
    public class HomeController : Controller
    {
        private readonly LiftContext _liftContext;

        public HomeController(LiftContext liftContext )
        {
            _liftContext = liftContext;
        }

        public IActionResult Index()
        {
            //var menus = _liftContext.Menus.ToList();
            //var result = from m in menus
            //            select new MenusVM
            //            {
            //                Icon = m.Icon,
            //                Id = m.Id,
            //                ParentId = m.ParentId,
            //                Url = m.Url
                        //};
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}