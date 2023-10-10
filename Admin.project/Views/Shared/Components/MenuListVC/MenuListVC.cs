using Admin.project.Contexts;
using Admin.project.Views.VM;
using Microsoft.AspNetCore.Mvc;

namespace Admin.project.Views.Shared.Components.MenuListVC
{
    public class MenuListVC : ViewComponent
    {
        private readonly LiftContext _context;

        public MenuListVC(LiftContext context)
        {
            _context = context;
        }

        //private readonly IRolServices _rolServices;

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var menus = _context.Menus.ToList();
            var result = from m in menus
                         select new MenusVM
                         {
                             Icon = m.Icon,
                             Id = m.Id,
                             ParentId = m.ParentId,
                             Url = m.Url
                         };
            return View(result);
        }
    }
}
