namespace Admin.project.Views.VM
{
    public class MenusVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public List<MenusVM> SubMenuList { get; set; }
    }
}
