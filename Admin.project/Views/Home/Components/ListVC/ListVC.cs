using Microsoft.AspNetCore.Mvc;

namespace Admin.project.Views.Home.Components.ListVC
{
    public class ListVC:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
