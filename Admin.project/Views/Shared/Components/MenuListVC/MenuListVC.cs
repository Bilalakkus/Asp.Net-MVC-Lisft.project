using Admin.project.Contexts;
using Admin.project.Models;
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
            var menu = GetSubmenu(menus, 0);
            //var result = from m in menus
            //             select new MenusVM
            //             {
            //                 Name=m.Name,
            //                 Icon = m.Icon,
            //                 Id = m.Id,
            //                 ParentId = m.ParentId,
            //                 Url = m.Url
            //             };
            return View(menu);
        }
        public List<MenusVM> GetSubmenu(List<Menu> menus, int parentId)
        {
            return menus.Where(m => m.ParentId == parentId)
                .Select(m => new MenusVM
                {
                    ParentId = m.ParentId,
                    Icon = m.Icon,
                    Id = m.Id,
                    Name = m.Name,
                    Url = m.Url,
                    SubMenuList = GetSubmenu(menus, m.Id)
                }).ToList();
        }
    }
}
