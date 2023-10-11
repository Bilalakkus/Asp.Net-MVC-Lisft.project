using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Admin.project.Views.Shared.Components.MessageVC
{
    public class MessageVC:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

           
            return View();
        }
    }
}
