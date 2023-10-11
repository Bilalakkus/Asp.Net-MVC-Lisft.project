using Microsoft.AspNetCore.Mvc;

namespace Admin.project.Views.Shared.Components.NotificationVC
{
    public class NotificationVC : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {


            return View();
        }
    }
}