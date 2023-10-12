using Microsoft.AspNetCore.Mvc;

namespace Admin.project.Views.Home.Components.CardVC
{
    public class CartVC:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
