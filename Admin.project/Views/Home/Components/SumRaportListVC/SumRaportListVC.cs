using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Admin.project.Views.Home.Components.SumRaportListVC
{
    public class SumRaportListVC:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            
            return View();
        }
    }
}
